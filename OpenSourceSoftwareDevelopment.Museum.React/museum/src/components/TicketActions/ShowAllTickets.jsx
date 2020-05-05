import React, { Component } from 'react';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../AppSettings';
import { Row, Table, Button } from 'react-bootstrap';
import Spinner from '../Spinner';

class ShowAllTickets extends Component{

    constructor(props){
        super(props);
        this.state = {
            tickets: [],
            isLoading: true,
        }
        this.ticketDetails = this.ticketDetails.bind(this);
    }

    componentDidMount(){
        this.getTickets();
    }

    getTickets(){
        const requestOptions = {
            method: 'GET' 
           };
            this.setState({isLoading: true});
            fetch(`${serviceConfig.baseURL}/api/Tickets/get`, requestOptions)
              .then(response => {
                if (!response.ok) {
                  return Promise.reject(response);
              }
              return response.json();
              })
              .then(data => {
                if (data) {
                  this.setState({ 
                      tickets: data,
                       isLoading: false });
                  }
              })
              .catch(response => {
                  NotificationManager.error(response.message || response.statusText);
                  this.setState({ isLoading: false });
              });
    }

  
    fillTableWithDaata() {
        return this.state.tickets.map(ticket => {
            return <tr key={ticket.id}>
                <td>{ticket.payment}</td>
                <td>{ticket.userId}</td>  
                <td>  <Button variant="dark"  width = "1%" className="text-center cursor-pointer" onClick = {() => this.ticketDetails(ticket.ticketId) }>vidi detalje</Button></td> 
               <td> <Button variant="dark"  width = "1%" className="text-center cursor-pointer" >izmeni</Button></td> 
               <td>  <Button variant="dark"  width = "1%" className="text-center cursor-pointer" >obriši</Button> </td>  
</tr>
    
    })
    }

    ticketDetails(id){
        this.props.history.push(`ticketDetails/${id}`);
    }

    render(){
        const {isLoading} = this.state;
        const rowsData = this.fillTableWithDaata();
        const table = (<Table striped bordered hover responsive striped variant="dark">
                            <thead>
                            <th>Plaćanje</th>
                            <th>Detalji</th>
                            <th>Izmene</th>
                            <th>Brisanje</th>
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
export default ShowAllTickets;