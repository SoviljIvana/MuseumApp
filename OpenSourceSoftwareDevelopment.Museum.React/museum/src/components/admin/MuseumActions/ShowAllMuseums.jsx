import React, { Component } from 'react';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../../AppSettings';
import { Row, Table, Button } from 'react-bootstrap';
import Spinner from '../../Spinner';

class ShowAllMuseums extends Component{
    constructor(props){
        super(props);
        this.state = {
            museums: [],
            isLoading: true
        }
        this.museumDetails = this.museumDetails.bind(this);
    }

    componentDidMount(){
      this.getMuseums();
    }

    getMuseums(){
        const requestOptions = {
            method: 'GET' ,
            headers: {'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + localStorage.getItem('jwt')}};
            this.setState({isLoading: true});
            fetch(`${serviceConfig.baseURL}/api/Museums/get`, requestOptions)
              .then(response => {
                if (!response.ok) {
                  return Promise.reject(response);
              }
              return response.json();
              })
              .then(data => {
                if (data) {
                  this.setState({ 
                      museums: data,
                       isLoading: false });
                  }
              })
              .catch(response => {
                  NotificationManager.error(response.message || response.statusText);
                  this.setState({ isLoading: false });
              });
        }

        fillTableWithDaata() {
            return this.state.museums.map(museum => {
                return <tr key={museum.id}>
                    <td>{museum.museumId}</td>
                    <td>{museum.name}</td>
                    <td>{museum.streetAndNumber}</td>
                    <td>{museum.city}</td>
                    <td>{museum.email}</td>
                    <td>{museum.phoneNubmer}</td>
                    <td>  <Button width = "1%" className="text-center cursor-pointer"  onClick={() => this.museumDetails(museum.museumId)}>vidi detalje</Button></td> 
                    <td> <Button width = "1%" className="text-center cursor-pointer" >izmeni</Button></td> 
               <td>  <Button width = "1%" className="text-center cursor-pointer" >obriši</Button> </td> 
                            </tr>
            })
        }
        museumDetails(id){
            this.props.history.push(`museumDetails/${id}`);
        }
        render(){
            const {isLoading} = this.state;
            const rowsData = this.fillTableWithDaata();
            const table = (<Table>
                                <thead>
                                <th>ID</th>
                                <th>NAZIV</th>
                                <th>ULICA I BROJ</th>
                                <th>GRAD</th>
                                <th>E-MAIL ADRESA</th>
                                <th>BROJ TELEFONA</th>
                                <th>VIDI DETALJE</th>
                                <th>IZMENA</th>
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

export default ShowAllMuseums;