import React, { Component } from 'react';
import { Col } from 'react-bootstrap';
import { Switch, NavLink, Route,} from 'react-router-dom';
import { Navbar, NavDropdown, Table  } from 'react-bootstrap';
import ShowAllMuseums from './MuseumActions/ShowAllMuseums';
import ShowAllAuditoriums from './AuditoriumActions/ShowAllAuditoriums';
import ShowAllExhibitions from './ExhibitionActions/ShowAllExhibitions';
import ShowAllExhibits from './ExhibitActions/ShowAllExhibits'
import ShowAllTags from './TagActions/ShowAllTags'
import ShowAllTickets from './TicketActions/ShowAllTickets'
import ShowAllUsers from './UserActions/ShowAllUsers'
import AddMuseum from './MuseumActions/AddMuseum';
import AddAuditorium from './AuditoriumActions/AddAuditorium';
import AddExhibition from './ExhibitionActions/AddExhibition';
import AddExhibit from './ExhibitActions/AddExhibit'
import AuditoriumDetails from './AuditoriumActions/AuditoriumDetails';
import ExhibitionDetails from './ExhibitionActions/ExhibitionDetails';
import MuseumDetails from './MuseumActions/MuseumDetails';
import ExhibitDetails from './ExhibitActions/ExhibitDetails';
import TagDetails from './TagActions/TagDetails';
import TicketDetails from './TicketActions/TicketDetails';
import UserDetails from './UserActions/UserDetails';
import EditUser from './UserActions/EditUser'
import EditAuditorium from './AuditoriumActions/EditAuditorium'
import EditExhibition from './ExhibitionActions/EditExhibition'
import EditExhibit from './ExhibitActions/EditExhibit'

class Dashboard extends Component {
    render() {
        return (
           <Table>
            <Navbar bg="dark"  >
                <NavDropdown title="Muzej" pill variant="light" id="basic-nav-dropdown" > 
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllMuseums'><h6>Lista muzeja</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/dashboard/AddMuseum'><h6>Dodaj muzej</h6></NavLink>

                </NavDropdown>
         
                <NavDropdown title="Sala" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllAuditoriums'><h6>Lista sala</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/dashboard/AddAuditorium'><h6>Dodaj salu</h6></NavLink>

                </NavDropdown>

                <NavDropdown title="Izložba" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllExhibitions'><h6>Lista izložba</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/dashboard/AddExhibition'><h6>Dodaj izlozbu</h6></NavLink>
                </NavDropdown>
            
                <NavDropdown title="Eksponati" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllExhibits'><h6>Lista eksponata</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/dashboard/AddExhibit'><h6>Dodaj eksponat</h6></NavLink>

                </NavDropdown>

                <NavDropdown title="Tagovi" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllTags'><h6>Lista tagova</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/dashboard/AddTag'><h6>Dodaj tag</h6></NavLink>

                </NavDropdown>

                <NavDropdown title="Karte" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllTickets'><h6>Lista karata</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/dashboard/AddTicket'><h6>Dodaj kartu</h6></NavLink>

                </NavDropdown>

                <NavDropdown title="Korisnici" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/dashboard/ShowAllUsers'><h6>Lista korisnika</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/dashboard/AddUser'><h6>Dodaj korisnika</h6></NavLink>

                </NavDropdown>
                </Navbar>
                    <Col className="pt-2 app-content-main">
                    <Switch>
                        <Route path="/dashboard/ShowAllMuseums" component={ShowAllMuseums} />
                        <Route path="/dashboard/ShowAllAuditoriums" component={ShowAllAuditoriums} />
                        <Route path="/dashboard/ShowAllExhibitions" component={ShowAllExhibitions} />
                        <Route path="/dashboard/ShowAllExhibits" component={ShowAllExhibits} />
                        <Route path="/dashboard/ShowAllTags" component={ShowAllTags} />
                        <Route path="/dashboard/ShowAllTickets" component={ShowAllTickets} />
                        <Route path="/dashboard/ShowAllUsers" component={ShowAllUsers} />
                        <Route path="/dashboard/AddMuseum" component={AddMuseum} />
                        <Route path="/dashboard/AddAuditorium" component={AddAuditorium} />
                        <Route path="/dashboard/AddExhibition" component={AddExhibition} />
                        <Route path="/dashboard/AddExhibit" component={AddExhibit} />
                        <Route path="/dashboard/AuditoriumDetails/:id" component={AuditoriumDetails} />
                        <Route path="/dashboard/ExhibitionDetails/:id" component={ExhibitionDetails} />
                        <Route path="/dashboard/MuseumDetails/:id" component={MuseumDetails} />
                        <Route path="/dashboard/ExhibitDetails/:id" component={ExhibitDetails} />
                       <Route path="/dashboard/TagDetails/:id" component={TagDetails} />
                       <Route path="/dashboard/TicketDetails/:id" component={TicketDetails} />
                       <Route path="/dashboard/UserDetails/:id" component={UserDetails} />
                       <Route path="/dashboard/EditUser/:id" component={EditUser} />
                       <Route path="/dashboard/EditAuditorium/:id" component={EditAuditorium} />
                       <Route path="/dashboard/EditExhibition/:id" component={EditExhibition} />
                       <Route path="/dashboard/EditExhibit/:id" component={EditExhibit} />
                       </Switch>
                </Col>
                </Table>
        );
    }
}

export default Dashboard;