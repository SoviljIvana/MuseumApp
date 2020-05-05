import React, { Component } from 'react';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../AppSettings';
import { Row, Table, Button , Card} from 'react-bootstrap';
import Spinner from '../Spinner';
import logo from '../Pictures/logo.png'
class ShowAllExhibitionsForUser extends Component{
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
            method: 'GET' 
        };
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
                return <Card border="dark" key={exhibition.id}>
                    <Card.Header><Button variant="light"  onClick={() => this.exhibitionDetails(exhibition.exhibitionId)}><h3>{exhibition.exhibitionName}</h3></Button></Card.Header>
                    <Card.Img variant="top" src="" />
                    <Card.Body>
                    <Card.Title><h6>Tema: {exhibition.typeOfExhibition}</h6></Card.Title>
                    <Card.Title> <Button variant="outline-success">{exhibition.startTime}</Button> -  <Button variant="outline-success"> {exhibition.endTime}</Button></Card.Title>
                    </Card.Body>
                    <Card.Footer>
                    <small className="text-muted">Last updated ? ago</small>
                </Card.Footer>
                    </Card>
            })
        }
        
        exhibitionDetails(id){
            this.props.history.push(`exhibitionDetails/${id}`);
        }

        render(){
            const {isLoading} = this.state;
            const rowsData = this.fillTableWithDaata();
            const table = (<Table striped bordered hover responsive striped>
                                <tbody>
                                    {rowsData}
                                </tbody>
                            </Table>);
            const showTable = isLoading ? <Spinner></Spinner> : table;
            return (
                <React.Fragment>
                    <Row >
                        {showTable}
                    </Row>
                </React.Fragment>
            );
        }
    }

export default ShowAllExhibitionsForUser;