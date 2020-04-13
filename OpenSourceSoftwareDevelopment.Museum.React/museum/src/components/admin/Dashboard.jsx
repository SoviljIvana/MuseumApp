import React, { Component } from 'react';
import { Col } from 'react-bootstrap';
import { Switch, NavLink, Route,} from 'react-router-dom';
import { Navbar, NavDropdown, Table  } from 'react-bootstrap';
import ShowAllMuseums from './MuseumActions/ShowAllMuseums';
import ShowAllAuditoriums from './AuditoriumActions/ShowAllAuditoriums';
import ShowAllExhibitions from './ExhibitionActions/ShowAllExhibitions';
import AuditoriumDetails from './AuditoriumActions/AuditoriumDetails';
import ExhibitionDetails from './ExhibitionActions/ExhibitionDetails';
import MuseumDetails from './MuseumActions/MuseumDetails'

class Dashboard extends Component {
    render() {
        return (
           <Table>
            <Navbar bg="dark"  >
                <NavDropdown title="Muzej" pill variant="light" id="basic-nav-dropdown" > 
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllMuseums'><h6>Lista muzeja</h6></NavLink>
                </NavDropdown>
         
                <NavDropdown title="Sala" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllAuditoriums'><h6>Lista sala</h6></NavLink>
                </NavDropdown>

                <NavDropdown title="Izložba" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllExhibitions'><h6>Lista izložba</h6></NavLink>
                </NavDropdown>
            
                </Navbar>
                    <Col className="pt-2 app-content-main">
                    <Switch>
                        <Route path="/dashboard/ShowAllMuseums" component={ShowAllMuseums} />
                        <Route path="/dashboard/ShowAllAuditoriums" component={ShowAllAuditoriums} />
                        <Route path="/dashboard/ShowAllExhibitions" component={ShowAllExhibitions} />
                        <Route path="/dashboard/AuditoriumDetails/:id" component={AuditoriumDetails} />
                        <Route path="/dashboard/ExhibitionDetails/:id" component={ExhibitionDetails} />
                        <Route path="/dashboard/MuseumDetails/:id" component={MuseumDetails} />

                       </Switch>
                </Col>
                </Table>
        );
    }
}

export default Dashboard;