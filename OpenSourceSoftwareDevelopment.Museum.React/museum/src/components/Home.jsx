import React, { Component } from 'react';
import { Col } from 'react-bootstrap';
import { Switch, NavLink, Route,} from 'react-router-dom';
import { Navbar, NavDropdown, Table  } from 'react-bootstrap';
import ShowAllMuseums from './MuseumActions/ShowAllMuseums';
import ShowAllAuditoriums from './AuditoriumActions/ShowAllAuditoriums';
import ShowAllExhibitions from './ExhibitionActions/ShowAllExhibitions';
import ComingSoonExhibitions from './ExhibitionActions/ComingSoonExhibitions';
import CurrentExhibitions from './ExhibitionActions/CurrentExhibitions';
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
import EditMuseum from'./MuseumActions/EditMuseum'

class Home extends Component {
    render() {
        return (
           <Table>
            <Navbar bg="dark"  >
                <NavDropdown title="Muzej" pill variant="light" id="basic-nav-dropdown" > 
                    <NavLink activeClassName="active-link" to='/home/ShowAllMuseums'><h6>Lista muzeja</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/home/AddMuseum'><h6>Dodaj muzej</h6></NavLink>

                </NavDropdown>
         
                <NavDropdown title="Sala" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/home/ShowAllAuditoriums'><h6>Lista sala</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/home/AddAuditorium'><h6>Dodaj salu</h6></NavLink>

                </NavDropdown>

                <NavDropdown title="Izložba" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/home/ShowAllExhibitions'><h6>Lista izložba</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/home/AddExhibition'><h6>Dodaj izlozbu</h6></NavLink>
               
                    <NavLink activeClassName="active-link" to='/home/ComingSoonExhibitions'><h6>Uskoro</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/home/CurrentExhibitions'><h6>izlozbe koje se trenutno prikazuju</h6></NavLink>
               
                </NavDropdown>
            
                <NavDropdown title="Eksponati" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/home/ShowAllExhibits'><h6>Lista eksponata</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/home/AddExhibit'><h6>Dodaj eksponat</h6></NavLink>

                </NavDropdown>

                <NavDropdown title="Tagovi" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/home/ShowAllTags'><h6>Lista tagova</h6></NavLink>
                    <NavLink activeClassName="active-link" to='/home/AddTag'><h6>Dodaj tag</h6></NavLink>

                </NavDropdown>

                <NavDropdown title="Karte" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/home/ShowAllTickets'><h6>Lista karata</h6></NavLink>

                </NavDropdown>

                <NavDropdown title="Korisnici" id="basic-nav-dropdown">
                    <NavLink activeClassName="active-link" to='/home/ShowAllUsers'><h6>Lista korisnika</h6></NavLink>

                </NavDropdown>
                </Navbar>
                    <Col className="pt-2 app-content-main">
                    <Switch>
                        <Route path="/home/ShowAllMuseums" component={ShowAllMuseums} />
                        <Route path="/home/ShowAllAuditoriums" component={ShowAllAuditoriums} />
                        <Route path="/home/ShowAllExhibitions" component={ShowAllExhibitions} />
                        <Route path="/home/ShowAllExhibits" component={ShowAllExhibits} />
                        <Route path="/home/CurrentExhibitions" component={CurrentExhibitions} />
                        <Route path="/home/ComingSoonExhibitions" component={ComingSoonExhibitions} />
                        <Route path="/home/ShowAllTags" component={ShowAllTags} />
                        <Route path="/home/ShowAllTickets" component={ShowAllTickets} />
                        <Route path="/home/ShowAllUsers" component={ShowAllUsers} />
                        <Route path="/home/AddMuseum" component={AddMuseum} />
                        <Route path="/home/AddAuditorium" component={AddAuditorium} />
                        <Route path="/home/AddExhibition" component={AddExhibition} />
                        <Route path="/home/AddExhibit" component={AddExhibit} />
                        <Route path="/home/AuditoriumDetails/:id" component={AuditoriumDetails} />
                        <Route path="/home/ExhibitionDetails/:id" component={ExhibitionDetails} />
                        <Route path="/home/MuseumDetails/:id" component={MuseumDetails} />
                        <Route path="/home/ExhibitDetails/:id" component={ExhibitDetails} />
                       <Route path="/home/TagDetails/:id" component={TagDetails} />
                       <Route path="/home/TicketDetails/:id" component={TicketDetails} />
                       <Route path="/home/UserDetails/:id" component={UserDetails} />
                       <Route path="/home/EditUser/:id" component={EditUser} />
                       <Route path="/home/EditAuditorium/:id" component={EditAuditorium} />
                       <Route path="/home/EditExhibition/:id" component={EditExhibition} />
                       <Route path="/home/EditExhibit/:id" component={EditExhibit} />
                       <Route path="/home/EditMuseum/:id" component={EditMuseum} />
                       </Switch>
                </Col>
                </Table>
        );
    }
}

export default Home;