import React, { Component } from 'react';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../../AppSettings';
import { Row, Table, Button } from 'react-bootstrap';
import Spinner from '../../Spinner';

class ShowAllAuditoriums extends Component{
    constructor(props){
        super(props);
        this.state = {
            auditoriums: [],
            isLoading: true,
        }
        this.auditoriumDetails = this.auditoriumDetails.bind(this);
    }

    componentDidMount(){
      this.getAuditoriums();
    }

    getAuditoriums(){
        const requestOptions = {
            method: 'GET' ,
            headers: {'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + localStorage.getItem('jwt')}};
            this.setState({isLoading: true});
            fetch(`${serviceConfig.baseURL}/api/Auditoriums/get`, requestOptions)
              .then(response => {
                if (!response.ok) {
                  return Promise.reject(response);
              }
              return response.json();
              })
              .then(data => {
                if (data) {
                  this.setState({ 
                      auditoriums: data,
                       isLoading: false });
                  }
              })
              .catch(response => {
                  NotificationManager.error(response.message || response.statusText);
                  this.setState({ isLoading: false });
              });
        }

        fillTableWithDaata() {
            return this.state.auditoriums.map(auditorium => {
                return <tr key={auditorium.id}>
                    <td>{auditorium.auditoriumId}</td>
                    <td>{auditorium.museumId}</td>
                    <td>{auditorium.nameOfAuditorium}</td>
                    <td>{auditorium.numberOfSeats}</td>
               <td>  <Button width = "1%" className="text-center cursor-pointer"  onClick={() => this.auditoriumDetails(auditorium.auditoriumId)}>vidi detalje</Button></td> 
               <td> <Button width = "1%" className="text-center cursor-pointer" >izmeni</Button></td> 
               <td>  <Button width = "1%" className="text-center cursor-pointer" >obriši</Button> </td> 
  </tr>
        
        })
        }

        auditoriumDetails(id){
            this.props.history.push(`auditoriumDetails/${id}`);
        }

        render(){
            const {isLoading} = this.state;
            const rowsData = this.fillTableWithDaata();
            const table = (<Table>
                                <thead>
                                <th>ID</th>
                                <th>MUZEJ ID</th>
                                <th>NAZIV AUDITORIUMA</th>
                                <th>BROS SEDIŠTA</th>
                                <th>DETALJI</th>
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

export default ShowAllAuditoriums;