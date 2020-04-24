import React, { Component } from 'react';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../AppSettings';
import { Row, Table, Button } from 'react-bootstrap';
import Spinner from '../Spinner';

class ShowAllExhibits extends Component {

    constructor(props) {
        super(props);
        this.state = {
            exhibits: [],
            isLoading: true,
        }
        this.exhibitDetails = this.exhibitDetails.bind(this);
        this.removeExhibit = this.removeExhibit.bind(this);
        this.editExhibit = this.editExhibit.bind(this);
    }

    componentDidMount() {
        this.getExhibits();
    }

    getExhibits() {
        const requestOptions = {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + localStorage.getItem('jwt')
            }
        };
        this.setState({ isLoading: true });
        fetch(`${serviceConfig.baseURL}/api/Exhibits/get`, requestOptions)
            .then(response => {
                if (!response.ok) {
                    return Promise.reject(response);
                }
                return response.json();
            })
            .then(data => {
                if (data) {
                    this.setState({
                        exhibits: data,
                        isLoading: false
                    });
                }
            })
            .catch(response => {
                NotificationManager.error(response.message || response.statusText);
                this.setState({ isLoading: false });
            });
    }

    removeExhibit(id) {
        const requestOptions = {
          method: 'DELETE',
          headers: {'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + localStorage.getItem('jwt')}
      };
  
      fetch(`${serviceConfig.baseURL}/api/exhibits/delete/${id}`, requestOptions)
          .then(response => {
              if (!response.ok) {
                  return Promise.reject(response);
              }
              return response.statusText;
          })
          .then(result => {
              NotificationManager.success('Successfuly removed exhibit with ID: '+ id);
              const newState = this.state.exhibits.filter(exhibit => {
                  return exhibit.id !== id;
              })
              this.setState({auditoriums: newState});
          })
          .catch(response => {
              NotificationManager.error("Unable to remove exhibit.");
              this.setState({ submitted: false });
          });
      }


    fillTableWithDaata() {
        return this.state.exhibits.map(exhibit => {
            return <tr key={exhibit.id}>
                <td>{exhibit.exhibitId}</td>
                <td>{exhibit.name}</td>
                <td>{exhibit.year}</td>
                <td>{exhibit.picturePath}</td>
                <td>{exhibit.auditoriumId}</td>
                <td>{exhibit.exhibitionId}</td>
                <td>  <Button width="1%" className="text-center cursor-pointer" onClick={() => this.exhibitDetails(exhibit.exhibitId)} >vidi detalje</Button></td>
                <td> <Button width="1%" className="text-center cursor-pointer"  onClick={() => this.editExhibit(exhibit.exhibitId)} >izmeni</Button></td>
                <td>  <Button width="1%" className="text-center cursor-pointer" onClick={() => this.removeExhibit(exhibit.exhibitId)}>obriši</Button> </td>
            </tr>

        })
    }

    exhibitDetails(id) {
        this.props.history.push(`exhibitDetails/${id}`);
    }
    editExhibit(id) {
        this.props.history.push(`editExhibit/${id}`);
    }

    render() {
        const { isLoading } = this.state;
        const rowsData = this.fillTableWithDaata();
        const table = (<Table striped bordered hover responsive striped>
            <thead>
                <th>ID</th>
                <th>NAZIV</th>
                <th>GODINA</th>
                <th>SLIKA</th>
                <th>ID SALE</th>
                <th>ID IZLOZBE</th>
                <th>VIDI DETALJE</th>
                <th>IZMENE</th>
                <th>BRISANJE</th>
            </thead>
            <tbody>
                {rowsData}
            </tbody>
        </Table>);
        const showTable = isLoading ? <Spinner></Spinner> : table;
        return (
            <React.Fragment>
                <Row>
                    {showTable}
                </Row>
            </React.Fragment>
        );
    }
}
export default ShowAllExhibits;