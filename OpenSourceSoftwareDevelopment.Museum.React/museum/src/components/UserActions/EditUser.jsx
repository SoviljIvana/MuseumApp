import React from 'react';
import { withRouter } from 'react-router-dom';
import { FormGroup, FormControl, Button, Container, Row, Col, FormText, } from 'react-bootstrap';
import { NotificationManager } from 'react-notifications';
import { serviceConfig } from '../../AppSettings';

class EditUser extends React.Component {

    constructor(props) {
        super(props);

        this.state = {
            firstName: '',
            lastName: '',
            email: '',
            id: 0,
            yearOfBirth: '',            
            submitted: false,
            canSubmit: true
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    componentDidMount() {
        const { id } = this.props.match.params; 
        this.getUser(id);
    }
    getUser(userId) {
        const requestOptions = {
            method: 'GET'
         
        };
    
        fetch(`${serviceConfig.baseURL}/api/users/get/` + userId, requestOptions)
            .then(response => {
            if (!response.ok) {
                return Promise.reject(response);
            }
            return response.json();
            })
            .then(data => {
                if (data) {
                    this.setState({firstName: data.firstName,
                        lastName: data.lastName,
                        email: data.email,
                        yearOfBirth: data.yearOfBirth,
                        userId: data.userId,
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
      
        this.validate(id, value);
    }

    validate(id, value) {
        if (id === 'name') {
            if (value === '') {
                this.setState({titleError: 'Fill in cinema title', 
                                canSubmit: false});
            } else {
                this.setState({titleError: '',
                                canSubmit: true});
            }
        }
    }    

    handleSubmit(e) {

        e.preventDefault();
        this.setState({ submitted: true });
        const {firstName, lastName, email, yearOfBirth, userId } = this.state;
        if (firstName && lastName && email  && yearOfBirth && userId) {
            this.updateUser();
        } else {
            NotificationManager.error('Please fill in data');
            this.setState({ submitted: false });
        }
    }
 
    updateUser() {

        const { firstName, lastName, email, yearOfBirth, userId } = this.state;
        const data = {
            UserId: userId,
            FirstName: firstName,
            LastName: lastName, 
            Email: email,
            YearOfBirth: yearOfBirth
        };

        const requestOptions = {
            method: 'PUT',
           
            body: JSON.stringify(data)
        };

        console.log(JSON.stringify("REQ_OPT:" + requestOptions.body));
        
        fetch(`${serviceConfig.baseURL}/api/users/put/${userId}`, requestOptions)
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
        const {firstName, lastName, email, yearOfBirth, userId ,canSubmit , submitted} = this.state;
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