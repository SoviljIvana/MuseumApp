import React, { Component } from 'react';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../AppSettings';
import { Container, CardDeck, Card, CardColumns, Button,ResponsiveEmbed} from 'react-bootstrap';
import Spinner from '../Spinner';

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

        getAllExhibitions() {
            return this.state.exhibitions.map(exhibition => {
                return <Card style={{ width: '20rem' }} className="text-center"  key={exhibition.id}>
                <Container>
                    <div className="inner">
                    <ResponsiveEmbed aspectRatio="4by3">
                  <Card.Img variant="top" src= {exhibition.picture} /> 
                  </ResponsiveEmbed>
                 </div>
                </Container>   
                <Container >
                    <Button>
                    <Card.Header onClick={() => this.exhibitionDetails(exhibition.exhibitionId)}><h6>{exhibition.exhibitionName}</h6></Card.Header>
                    </Button>
                </Container>
                    <Card.Body>
                <Container>
                    <Card.Text> {exhibition.about}</Card.Text>
                </Container>
                </Card.Body>
                <Container>
                    <Card.Footer className="text-muted">
                   {exhibition.startTime} - {exhibition.endTime} </Card.Footer></Container>
              
                   
            </Card>
            })
        }
        
        exhibitionDetails(id){
            this.props.history.push(`exhibitionDetails/${id}`);
        }

        render(){
            const {isLoading} = this.state;
            const exhibitionDetails = this.getAllExhibitions();
            const exhibitions = isLoading ? <Spinner></Spinner> :<Container className= "container-cards"> {exhibitionDetails} </Container>;
            return (
               
                        <CardColumns className= "cardColumns" >
                        {exhibitions}
                        </CardColumns>
                     
            );
        }
    }

export default ShowAllExhibitionsForUser;