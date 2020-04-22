import React from 'react';
import { withRouter } from 'react-router-dom';
import { FormGroup, FormControl, Button, Container, Row, Col, FormText, } from 'react-bootstrap';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../../appSettings';

class EditUser extends React.Component {

    constructor(props) {
        super(props);

        this.state = {
            firstName: '',
            lastName: '',
            email: '',
            yearOfBirth: '',            
            submitted: false,
            canSubmit: true
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleChange(e) {
        const { id, value } = e.target;
        this.setState({ [id]: value });
        this.validate(id, value);
    }    

    handleSubmit(e) {

        e.preventDefault();
        this.setState({ submitted: true });
        const {firstName, lastName, email, yearOfBirth } = this.state;
        if (firstName && lastName && email  && yearOfBirth) {
            this.updateUser();
        } else {
            NotificationManager.error('Please fill in data');
            this.setState({ submitted: false });
        }
    }
 
    updateUser() {

        const { firstName, lastName, email, yearOfBirth } = this.state;
        const data = {
            FirstName: firstName,
            LastName: lastName, 
            Email: email,
            YearOfBirth: yearOfBirth
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
        
        fetch(`${serviceConfig.baseURL}/api/users/put/${id}`, requestOptions)
            .then(response => {
                if (!response.ok) {
                    return Promise.reject(response);
                }
                return response.statusText;
            })
            .then(data => {
                if(data){
                    this.setState({
                        firstName : data.firstName,
                        lastName: data.lastName,
                        email: data.email,
                        yearOfBirth: data.yearOfBirth
                    });
                }
            })
            .then(result => {
                this.props.history.goBack();
                NotificationManager.success('Successfuly edited user!');
            })
            .catch(response => {
                NotificationManager.error("Unable to update user. ");
                this.setState({ submitted: false });
            });
    }

    render() {
        const {firstName, lastName, email, yearOfBirth, canSubmit , submitted} = this.state;
        return (
            <Container>
                <Row>
                    <Col>
                        <form onSubmit={this.handleSubmit}>
                            <FormGroup>
                                <FormControl
                                    id="firstName"
                                    type="text"
                                    placeholder="firstName"
                                    value={firstName}
                                    onChange={this.handleChange}
                                />
                            </FormGroup>
                            <FormGroup>
                                <FormControl
                                    id="lastName"
                                    type="text"
                                    placeholder="lastName"
                                    value={lastName}
                                    onChange={this.handleChange}
                                />
                            </FormGroup>
                            <FormGroup>
                                <FormControl
                                    id="email"
                                    type="text"
                                    placeholder="email"
                                    value={email}
                                    onChange={this.handleChange}
                                />
                            </FormGroup>
                            <FormGroup>
                                <FormControl
                                    id="yearOfBirth"
                                    type="text"
                                    placeholder="yearOfBirth"
                                    value={yearOfBirth}
                                    onChange={this.handleChange}
                                />
                            </FormGroup>
                            <Button  variant="danger" type="submit" disabled={submitted || !canSubmit} block>Edit user</Button>
                        </form>
                    </Col>
                </Row>
            </Container>
        );
    }
}
export default withRouter(EditUser);