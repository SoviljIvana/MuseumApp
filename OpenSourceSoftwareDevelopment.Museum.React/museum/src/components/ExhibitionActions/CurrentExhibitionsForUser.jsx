import React, { Component } from 'react';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../AppSettings';
import {  Card, Container } from 'react-bootstrap';
import Spinner from '../Spinner';

class CurrentExhibitionsForUser extends Component{
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
            fetch(`${serviceConfig.baseURL}/api/Exhibitions/get/currentExhibitions`, requestOptions)
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

        getAllExhibitions() {
            return this.state.exhibitions.map(exhibition => {
                return <Card className= "card"  key={exhibition.id}>
                            <Container>
                                <Card.Header onClick={() => this.exhibitionDetails(exhibition.exhibitionId)}>{exhibition.exhibitionName}</Card.Header>
                            </Container>
                            <Card.Body>
                            <Container>
                                <Card.Text>Tema: {exhibition.typeOfExhibition} </Card.Text>
                            </Container>
                            <Container>
                                <Card.Text> {exhibition.startTime} - {exhibition.endTime}</Card.Text>
                            </Container>
                                </Card.Body>
                            <Container>
                                <Card.Footer> <small className="text-muted">Last updated ? ago</small> </Card.Footer>
                            </Container>
                        </Card>
            })
        }
        
        exhibitionDetails(id){
            this.props.history.push(`exhibitionDetails/${id}`);
        }

        render(){
            const {isLoading} = this.state;
            const exhibitionDetails = this.getAllExhibitions();
            const exhibitions = isLoading ? <Spinner></Spinner> :<Container> {exhibitionDetails} </Container>;
            return (
                    <Container>
                        {exhibitions}
                    </Container>
            );
        }
    }

export default CurrentExhibitionsForUser;