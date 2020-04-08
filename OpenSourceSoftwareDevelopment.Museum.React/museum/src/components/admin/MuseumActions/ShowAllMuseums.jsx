import React, { Component } from 'react';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../../AppSettings';
import { Row, Table } from 'react-bootstrap';
import Spinner from '../../Spinner';

class ShowAllMuseums extends Component{
    constructor(props){
        super(props);
        this.state = {
            museums: [],
            isLoading: true
        }
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
                            </tr>
            })
        }

        render(){
            const {isLoading} = this.state;
            const rowsData = this.fillTableWithDaata();
            const table = (<Table>
                                <thead>
                                <th>Id</th>
                                <th>Name</th>
                                <th>Street</th>
                                <th>City</th>
                                <th>Email</th>
                                <th>Phone number</th>
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