import React from 'react';
import { withRouter } from 'react-router-dom';
import { Container, FormText} from 'react-bootstrap';
import { NotificationManager } from 'react-notifications';
import { serviceConfig,  } from '../../AppSettings';

class TagDetails extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            id: '',
            name: '',
            type: '',
          
        };
    }

    componentDidMount() {
        const {id} = this.props.match.params;
        this.getTag(id);
    }
    
    getTag(id) {
        const requestOptions = {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + localStorage.getItem('jwt')
            }
        };
        fetch(`${serviceConfig.baseURL}/api/tags/get/${id}` , requestOptions)
            .then(response => {
                if (!response.ok) {
                    return Promise.reject(response);
                }
                return response.json();
            })
            .then(data => {
                if (data) {
                    this.setState({
                        tagId: data.id,
                        name: data.name + '',
                        type: data.type +'',
                     
                    });
                }
            })
            .catch(response => {
                NotificationManager.error(response.message || response.statusText);
                this.setState({ submitted: false });
            });
    }

    render() {
        const {tagId, name, type} = this.state;
        return (
            <Container>
                <FormText className="text-danger"><h3>TAG ID: {tagId}</h3></FormText>
                <FormText className="text-danger"><h3>NAZIV: {name}</h3></FormText>
                <FormText className="text-danger"><h3>VRSTA: {type}</h3></FormText>
            </Container>
        );
    }
}
export default withRouter(TagDetails);