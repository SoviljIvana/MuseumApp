import React, { Component } from 'react';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../AppSettings';
import { Row, Table, Button } from 'react-bootstrap';
import Spinner from '../Spinner';

class ShowAllTags extends Component{

    constructor(props){
        super(props);
        this.state = {
            tags: [],
            isLoading: true,
        }
        this.tagDetails = this.tagDetails.bind(this);
    }

    componentDidMount(){
        this.getTags();
    }

    getTags(){
        const requestOptions = {
            method: 'GET' ,
            headers: {'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + localStorage.getItem('jwt')}};
            this.setState({isLoading: true});
            fetch(`${serviceConfig.baseURL}/api/tags/get`, requestOptions)
              .then(response => {
                if (!response.ok) {
                  return Promise.reject(response);
              }
              return response.json();
              })
              .then(data => {
                if (data) {
                  this.setState({ 
                      tags: data,
                       isLoading: false });
                  }
              })
              .catch(response => {
                  NotificationManager.error(response.message || response.statusText);
                  this.setState({ isLoading: false });
              });
    }

  
    fillTableWithDaata() {
        return this.state.tags.map(tag => {
            return <tr key={tag.id}>
                <td>{tag.name}</td>
                <td>{tag.type}</td>    
                <td>  <Button variant="dark"  width = "1%" className="text-center cursor-pointer"   onClick={() => this.tagDetails(tag.id)}>vidi detalje</Button></td> 
               <td> <Button variant="dark"  width = "1%" className="text-center cursor-pointer" >izmeni</Button></td> 
               <td>  <Button variant="dark" width = "1%" className="text-center cursor-pointer" >obriši</Button> </td>  
</tr>
    
    })
    }

    tagDetails(id){
        this.props.history.push(`tagDetails/${id}`);
    }

    render(){
        const {isLoading} = this.state;
        const rowsData = this.fillTableWithDaata();
        const table = (<Table striped bordered hover responsive striped variant="dark">
                            <thead>
                            <th>Naziv</th>
                            <th>Vrsta</th>
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
export default ShowAllTags;