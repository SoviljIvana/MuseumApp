import React, { Component } from 'react';
import { Row, Col } from 'react-bootstrap';
import { Switch, NavLink, Route } from 'react-router-dom';
import {  Badge } from 'react-bootstrap';
import ShowAllMuseums from './MuseumActions/ShowAllMuseums';
import ShowAllAuditoriums from './AuditoriumActions/ShowAllAuditoriums';

class Dashboard extends Component {
    render() {
        return (
            <Row className="justify-content-center no-gutters">
                <Col lg={2} className="dashboard-navigation">
                    <Row className="justify-content-center">
                       <Badge pill variant="light"><h2>MUSEUMS</h2></Badge>
                    </Row>
                    <Row className="justify-content-center mt-2">
                        <NavLink activeClassName="active-link" to='/dashboard/ShowAllMuseums'><Badge pill variant="dark"><h5>ALL MUSEUMS</h5></Badge></NavLink>
                    </Row>
                    <Row className="justify-content-center">
                       <Badge pill variant="light"><h2>AUDITORIUMS</h2></Badge>
                    </Row>
                    <Row className="justify-content-center mt-2">
                        <NavLink activeClassName="active-link" to='/dashboard/ShowAllAuditoriums'><Badge pill variant="dark"><h5>ALL AUDITORIUMS</h5></Badge></NavLink>
                    </Row>
                </Col>
              
                <Col className="pt-2 app-content-main">
                    <Switch>
                        <Route path="/dashboard/ShowAllMuseums" component={ShowAllMuseums} />
                        <Route path="/dashboard/ShowAllAuditoriums" component={ShowAllAuditoriums} />
                       </Switch>
                </Col>
            </Row>
        );
    }
}

export default Dashboard;