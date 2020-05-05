import React from 'react';
import { withRouter } from 'react-router-dom';
import { FormGroup, FormControl, Button, Container, Row, Col} from 'react-bootstrap';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../AppSettings';

class AddExhibition extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            exhibitionId: 0,
            exhibitionName: '',
            auditoriumId: 0,
            typeOfExhibition: '',
            startTime: '',
            endTime: '',
            submitted: false,
            canSubmit: true
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleChange(e) {
        const { id, value } = e.target;
        this.setState({ [id]: value });
    }
    
    handleSubmit(e) {
        e.preventDefault();
        this.setState({ submitted: true });
        const { exhibitionName, typeOfExhibition} = this.state;
        if (exhibitionName && typeOfExhibition) {
            this.newExhibition();
        } else {
            NotificationManager.error('Please fill in data');
            this.setState({ submitted: false });
        }
    }

    newExhibition() {
        const {exhibitionId, exhibitionName, auditoriumId, typeOfExhibition, startTime, endTime} = this.state;

        const data = {
            ExhibitionId: +exhibitionId,
            ExhibitionName: exhibitionName,
            AuditoriumId: +auditoriumId,
            TypeOfExhibition: typeOfExhibition,
            StartTime : startTime,
            EndTime: endTime,
        };

        const requestOptions = {
            method: 'POST',
           
            body: JSON.stringify(data)
        };

        fetch(`${serviceConfig.baseURL}/api/exhibitions/post`, requestOptions)
            .then(response => {
                if (!response.ok) {
                    return Promise.reject(response);
                }
                return response.statusText;
            })
            .then(result => {
                NotificationManager.success('Successfuly added exhibition!');
                this.props.history.push(`ShowAllExhibitions`);
            })
            .catch(response => {
                NotificationManager.error(response.message || response.statusText);
                this.setState({ submitted: false });
            });
    }
    

    render() {
        const {exhibitionId, exhibitionName, auditoriumId, typeOfExhibition, startTime, endTime,  submitted, canSubmit } = this.state;
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
                                    id="exhibitionId"
                                    type="number"
                                    placeholder="exhibitionId"
                                    value={exhibitionId}
                                    onChange={this.handleChange}
                                />
                          </FormGroup>
                            <FormGroup>
                                <FormControl
                                    id="auditoriumId"
                                    type="number"
                                    placeholder="auditoriumId"
                                    value={auditoriumId}
                                    onChange={this.handleChange}
                                />
                            </FormGroup>
                            <FormGroup>
                                <FormControl
                                    id="startTime"
                                    type="date"
                                    placeholder="startTime"
                                    value={startTime}
                                    onChange={this.handleChange}
                                />
                            </FormGroup>
                            <FormGroup>
                                <FormControl
                                    id="endTime"
                                    type="date"
                                    placeholder="endTime"
                                    value={endTime}
                                    onChange={this.handleChange}
                                />
                            </FormGroup>
                            <Button  variant="info" type="submit" disabled={submitted || !canSubmit} block>Add Exhibition</Button>
                        </form>
                    </Col>
                </Row>
            </Container>
        );
    }
}

export default withRouter(AddExhibition);