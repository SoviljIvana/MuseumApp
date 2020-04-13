import React, { Component } from 'react';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../../AppSettings';
import { Row, Table, Button } from 'react-bootstrap';
import Spinner from '../../Spinner';

class ShowAllExhibitions extends Component{
    constructor(props){
        super(props);
        this.state = {
            exhibitions: [],
            isLoading: true
        }
        this.exhibitionDetails = this.exhibitionDetails.bind(this);

    }

    componentDidMount(){
      this.getExhibitions();
    }

    getExhibitions(){
        const requestOptions = {
            method: 'GET' ,
            headers: {'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + localStorage.getItem('jwt')}};
            this.setState({isLoading: true});
            fetch(`${serviceConfig.baseURL}/api/Exhibitions/get`, requestOptions)
              .then(response => {
                if (!response.ok) {
                  return Promise.reject(response);
              }
              return response.json();
              })
              .then(data => {
                if (data) {
                  this.setState({ 
                    exhibitions: data,
                       isLoading: false });
                  }
              })
              .catch(response => {
                  NotificationManager.error(response.message || response.statusText);
                  this.setState({ isLoading: false });
              });
        }

        fillTableWithDaata() {
            return this.state.exhibitions.map(exhibition => {
                return <tr key={exhibition.id}>
                    <td>{exhibition.exhibitionId}</td>
                    <td>{exhibition.exhibitionName}</td>
                    <td>{exhibition.auditoriumId}</td>
                    <td>{exhibition.typeOfExhibition}</td>
                    <td>{exhibition.startTime}</td>
                    <td>{exhibition.endTime}</td>
                    <td>  <Button width = "1%" className="text-center cursor-pointer"  onClick={() => this.exhibitionDetails(exhibition.exhibitionId)}>vidi detalje</Button></td> 
                    <td> <Button width = "1%" className="text-center cursor-pointer" >izmeni</Button></td> 
               <td>  <Button width = "1%" className="text-center cursor-pointer" >obriši</Button> </td> 
                            </tr>
            })
        }
        exhibitionDetails(id){
            this.props.history.push(`exhibitionDetails/${id}`);
        }

        render(){
            const {isLoading} = this.state;
            const rowsData = this.fillTableWithDaata();
            const table = (<Table>
                                <thead>
                                <th>ID</th>
                                <th>NAZIV</th>
                                <th>SALA ID</th>
                                <th>VRSTA IZLOŽBE</th>
                                <th>DATUM OTVARANJA IZLOŽBE</th>
                                <th>DATUM ZATVARANJA IZLOŽBE</th>
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

export default ShowAllExhibitions;