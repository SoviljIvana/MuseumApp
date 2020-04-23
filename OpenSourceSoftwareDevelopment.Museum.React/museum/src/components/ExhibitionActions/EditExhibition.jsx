import React from 'react';
import { withRouter } from 'react-router-dom';
import { FormGroup, FormControl, Button, Container, Row, Col, FormText, } from 'react-bootstrap';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../AppSettings';

class EditExhibition extends React.Component {

    constructor(props) {
        super(props);

        this.state = {

            startTime: '',
            endTime: '',
            typeOfExhibition: '',
            exhibitionName: '',
            exhibitionId: 0,
            auditoriumId: 0,            
            submitted: false,
            canSubmit: true
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    componentDidMount() {
        const { id } = this.props.match.params; 
        this.getExhibition(id);
    }
    getExhibition(exhibitionId) {
        const requestOptions = {
            method: 'GET',
            headers: {'Content-Type': 'application/json',
                          'Authorization': 'Bearer ' + localStorage.getItem('jwt')}
        };
    
        fetch(`${serviceConfig.baseURL}/api/exhibitions/get/` + exhibitionId, requestOptions)
            .then(response => {
            if (!response.ok) {
                return Promise.reject(response);
            }
            return response.json();
            })
            .then(data => {
                if (data) {
                    this.setState({typeOfExhibition: data.typeOfExhibition,
                        exhibitionName: data.exhibitionName,
                        exhibitionId: data.exhibitionId,
                        auditoriumId: data.auditoriumId,
                        startTime: data.startTime,
                        endTime: data.endTime,
                        id: data.id});
                }
            })
            .catch(response => {
                NotificationManager.error(response.message || response.statusText);
                this.setState({ submitted: false });
            });
        }
    handleChange(e) {
        const { id, value } = e.target;
        this.setState({ [id]: value });
      
            }


    handleSubmit(e) {

        e.preventDefault();
        this.setState({ submitted: true });
        const {auditoriumId, exhibitionId, exhibitionName, typeOfExhibition, startTime, endTime} = this.state;
        if (auditoriumId && exhibitionId && exhibitionName && typeOfExhibition && startTime && endTime) {
            this.updateExhibition();
        } else {
            NotificationManager.error('Please fill in data');
            this.setState({ submitted: false });
        }
    }
 
    updateExhibition() {

        const { auditoriumId, exhibitionId, exhibitionName, typeOfExhibition, startTime, endTime} = this.state;
        const data = {
            auditoriumId: auditoriumId,
            exhibitionId: exhibitionId,
            exhibitionName: exhibitionName, 
            typeOfExhibition: typeOfExhibition,
            startTime:startTime,
            endTime: endTime
        };

        const requestOptions = {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + localStorage.getItem('jwt')
            },
            body: JSON.stringify(data)
        };

        console.log(JSON.stringify("REQ_OPT:" + requestOptions.body));
        
        fetch(`${serviceConfig.baseURL}/api/exhibitions/${exhibitionId}`, requestOptions)
            .then(response => {
                if (!response.ok) {
                    return Promise.reject(response);
                }
                return response.statusText;
            })
            .then(data => {
                if(data){
                    this.setState({
                        exhibitionName : data.exhibitionName,
                        typeOfExhibition: data.typeOfExhibition,
                        startTime: data.startTime,
                        endTime: data.endTime
                    });
                }
            })
            .then(result => {
                this.props.history.goBack();
                NotificationManager.success('Successfuly edited exhibition!');
            })
            .catch(response => {
                NotificationManager.error("Unable to update exhibition. ");
                this.setState({ submitted: false });
            });
    }

    render() {
        const {exhibitionName, typeOfExhibition, startTime, endTime, canSubmit , submitted} = this.state;
        return (
            <Container>
                <Row>
                    <Col>
                        <form onSubmit={this.handleSubmit}>
                        
                            <FormGroup>
                                <FormControl
                                
                                    id="exhibitionName"
                                    type="text"
                                    placeholder="exhibitionName"
                                    value={exhibitionName}
                                    onChange={this.handleChange}
                                />
                            </FormGroup>
                            <FormGroup>
                                <FormControl
                                
                                    id="typeOfExhibition"
                                    type="text"
                                    placeholder="typeOfExhibition"
                                    value={typeOfExhibition}
                                    onChange={this.handleChange}
                                />
                            </FormGroup>
                            <FormGroup>
                                <FormControl
                                    id="startTime"
                                    type="text"
                                    placeholder="startTime"
                                    value={startTime}
                                    onChange={this.handleChange}
                                />
                            </FormGroup>
                            <FormGroup>
                                <FormControl
                                    id="endTime"
                                    type="text"
                                    placeholder="endTime"
                                    value={endTime}
                                    onChange={this.handleChange}
                                />
                            </FormGroup>
                            <Button  variant="danger" type="submit" disabled={submitted || !canSubmit} block>Edit exhibition</Button>
                        </form>
                    </Col>
                </Row>
            </Container>
        );
    }
}
export default withRouter(EditExhibition);