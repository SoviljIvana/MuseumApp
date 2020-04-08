import React, { Component } from 'react';
import { Col } from 'react-bootstrap';
import { Switch, NavLink, Route,} from 'react-router-dom';
import { Navbar, NavDropdown, Table  } from 'react-bootstrap';
import ShowAllMuseums from './MuseumActions/ShowAllMuseums';
import ShowAllAuditoriums from './AuditoriumActions/ShowAllAuditoriums';
import ShowAllExhibitions from './ExhibitionActions/ShowAllExhibitions';

class Dashboard extends Component {
    render() {
        return (
           <Table>
            <Navbar bg="dark"  >
                <NavDropdown title="Museum" pill variant="light" id="basic-nav-dropdown" > 
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllMuseums'><h6>all museums</h6></NavLink>
                </NavDropdown>
         
                <NavDropdown title="Auditorium" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllAuditoriums'><h6>all auditoriums</h6></NavLink>
                </NavDropdown>

                <NavDropdown title="Exhibition" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllExhibitions'><h6>all exhibitions</h6></NavLink>
                </NavDropdown>
                </Navbar>
                    <Col className="pt-2 app-content-main">
                    <Switch>
                        <Route path="/dashboard/ShowAllMuseums" component={ShowAllMuseums} />
                        <Route path="/dashboard/ShowAllAuditoriums" component={ShowAllAuditoriums} />
                        <Route path="/dashboard/ShowAllExhibitions" component={ShowAllExhibitions} />
                       </Switch>
                </Col>
                </Table>
        );
    }
}

export default Dashboard;