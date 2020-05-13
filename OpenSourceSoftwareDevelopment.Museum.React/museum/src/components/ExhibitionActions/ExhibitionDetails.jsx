import React from 'react';
import { withRouter } from 'react-router-dom';
import { Container, FormText, Table,Card, Button,ListGroup, ResponsiveEmbed, CardColumns } from 'react-bootstrap';
import { NotificationManager } from 'react-notifications';
import { serviceConfig,  } from '../../AppSettings';
import Spinner from '../Spinner'
import * as Moment from 'moment';  

import "react-datepicker/dist/react-datepicker.css";
class ExhibitionDetails extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            id: '',
            auditoriumId: '',
            exhibitionName: '',
            typeOfExhibition : '',
            startTime : '',
            endTime : '',
            about : '',
            picture : '',
            exhibits : [],
        };
    }

    componentDidMount() {
        const {id} = this.props.match.params;
        this.getExhibition(id);
    }
    
    getExhibition(id) {
        const requestOptions = {
            method: 'GET'
        };
        fetch(`${serviceConfig.baseURL}/api/exhibitions/get/${id}` , requestOptions)
            .then(response => {
                if (!response.ok) {
                    return Promise.reject(response);
                }
                return response.json();
            })
            .then(data => {
         
                if (data) {
                    this.setState({
                        exhibitionId: data.exhibitionId,
                        auditoriumId: data.auditoriumId ,
                        exhibitionName: data.exhibitionName + '',
                        typeOfExhibition : data.typeOfExhibition + '',
                        startTime : data.startTime +'',
                        endTime : data.endTime + '',
                        about : data.about + '',
              
                        picture :  data.picture + '',
                        exhibits: data.exhibits,
                        isLoading: false,
                    });
               
                }
            
            })
            .catch(response => {
                NotificationManager.error(response.message || response.statusText);
                this.setState({ submitted: false });
            });
    }
    getAllExhibits() {

        return this.state.exhibits.map(exhibit => {
          return <Card className = "center1" style={{ width: '20rem' }} className="text-center"  key={exhibit.exhibitId}>
          <Container>
              <div className="inner">
              <ResponsiveEmbed aspectRatio="4by3">
            <Card.Img variant="top" src= {exhibit.picturePath} /> 
            </ResponsiveEmbed>
           </div>
          </Container>   
          <Container >
              <Button>
              <Card.Header>{exhibit.name}</Card.Header>
              </Button>
          </Container>
              <Card.Body>
          <Container>
              <Card.Text> {exhibit.year}</Card.Text>
          </Container>
          </Card.Body>
      </Card>
        })
      }

    render() {
        const {isLoading} = this.state;
            const exhibitDetails = this.getAllExhibits();
            const exhibits = isLoading ? <Spinner></Spinner> :<Container className= "container-cards"> {exhibitDetails} </Container>;
        const {exhibitionId, auditoriumId, exhibitionName, typeOfExhibition, startTime, endTime, about, picture} = this.state;
        return (
            <Container>
<FormText className="text-danger">
                     {exhibitionName}</FormText>
               
                <Container>
                <div className="inner">
              <ResponsiveEmbed aspectRatio="4by3">
            <Card.Img variant="top" src= {picture} /> 
            </ResponsiveEmbed></div>     
            </Container>
              <ListGroup>
                    <ListGroup.Item  variant="secondary">
                     {about}
                    </ListGroup.Item>
                    <ListGroup.Item  variant="success">
                    {Moment(startTime).format('LLL')} - {Moment(endTime).format('LLL')}
                    </ListGroup.Item>
                    <ListGroup.Item  variant="danger">
                    Tema: {typeOfExhibition}
                    </ListGroup.Item>
                    <ListGroup.Item  variant="warning">
                    Eksponati:
                    </ListGroup.Item>
                    </ListGroup>
                  <CardColumns>
                  {exhibits} 
                  </CardColumns>
      
              
=           </Container>
        );
    }
}
export default withRouter(ExhibitionDetails);