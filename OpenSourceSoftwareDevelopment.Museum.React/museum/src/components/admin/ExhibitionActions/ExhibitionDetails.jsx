import React from 'react';
import { withRouter } from 'react-router-dom';
import { Container, FormText} from 'react-bootstrap';
import { NotificationManager } from 'react-notifications';
import { serviceConfig,  } from '../../../AppSettings';

class ExhibitionDetails extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            id: '',
            auditoriumId: '',
            exhibitionName: '',
            typeOfExhibition : '',
            startTime : '',
            endTime : ''
        };
    }

    componentDidMount() {
        const {id} = this.props.match.params;
        this.getExhibition(id);
    }
    
    getExhibition(id) {
        const requestOptions = {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + localStorage.getItem('jwt')
            }
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
                        endTime : data.endTime + ''
                    });
                }
            })
            .catch(response => {
                NotificationManager.error(response.message || response.statusText);
                this.setState({ submitted: false });
            });
    }

    render() {
        const {exhibitionId, auditoriumId, exhibitionName, typeOfExhibition, startTime, endTime} = this.state;
        return (
            <Container>
                <FormText className="text-danger"><h3>ID: {exhibitionId}</h3></FormText>
                <FormText className="text-danger"><h3>AUDITORIUM ID: {auditoriumId}</h3></FormText>
                <FormText className="text-danger"><h3>NAZIV IZLOŽBE: {exhibitionName}</h3></FormText>
                <FormText className="text-danger"><h3>VRSTA IZLOŽBE: {typeOfExhibition}</h3></FormText>
                <FormText className="text-danger"><h3>DATUM POČETKA IZLOŽBE: {startTime}</h3></FormText>
                <FormText className="text-danger"><h3>DATUM KRAJA IZLOŽBE: {endTime}</h3></FormText>

            </Container>
        );
    }
}
export default withRouter(ExhibitionDetails);