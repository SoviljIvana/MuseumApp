import React, { Component } from 'react';
import { Col, Row } from 'react-bootstrap';
import { Switch, NavLink, Route, Link } from 'react-router-dom';
import { FaUser } from 'react-icons/fa';
import { Navbar, Table, Nav, Form, Button, Carousel, Container, } from 'react-bootstrap';
import ShowAllMuseums from './MuseumActions/ShowAllMuseums';
import ShowAllAuditoriums from './AuditoriumActions/ShowAllAuditoriums';
import ShowAllExhibitionsForUser from './ExhibitionActions/ShowAllExhibitionsForUser';
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
import EditMuseum from './MuseumActions/EditMuseum'
import CurrentExhibitionsForUser from './ExhibitionActions/CurrentExhibitionsForUser'
import ComingSoonExhibitionsForUser from './ExhibitionActions/ComingSoonExhibitionsForUser'
import picture1 from './picture1.jpg';
import { Fade } from 'react-slideshow-image';

const fadeImages = [
    picture1
];

const fadeProperties = {
    duration: 5000,
    transitionDuration: 500,
    infinite: false,
    indicators: true,
    onChange: (oldIndex, newIndex) => {
        console.log(`fade transition from ${oldIndex} to ${newIndex}`);
    }
}

class Home extends Component {

    render() {
        return (
              <Row className="no-gutters pr-1 pl-1" > 
                <Table>
                    <Navbar sticky="top" className="slide-container" expand="lg"  bg="dark">
                        <Nav  className="mr-auto">
                            <Container>
                                <Navbar.Brand ><Link to='/home/ShowAllExhibitionsForUser'><Button variant="dark" >Izložbe</Button></Link></Navbar.Brand>
                                </Container>
                        </Nav>
                        <Nav  className="mr-auto">
                            <Container>
                            <Navbar.Brand><Link to='/home/ComingSoonExhibitionsForUser'><Button variant="dark">Uskoro</Button></Link></Navbar.Brand>
                                </Container>
                        </Nav>
                        <Nav  className="mr-auto">
                            <Container>
                            <Navbar.Brand><Link to='/home/CurrentExhibitionsForUser'><Button variant="dark" >Trenutno se prikazuju</Button></Link></Navbar.Brand>
                                </Container>
                        </Nav>
                        <Nav  className="mr-auto">
                            <Container>
                            <Navbar.Brand><Link to=''><Button size="lg" variant="dark" active>Home</Button></Link></Navbar.Brand>
                                </Container>
                        </Nav>
                        <Nav  className="mr-auto">
                            <Container>
                            <Navbar.Brand><Link to=''><Button  variant="dark">O muzeju</Button></Link></Navbar.Brand>
                                </Container>
                        </Nav>
                        <Nav  className="mr-auto">
                            <Container>
                            <Navbar.Brand><Link to=''><Button variant="dark">Kontakt</Button></Link></Navbar.Brand>                                   
                                </Container>
                        </Nav>
                                <Navbar.Collapse className="justify-content-end">
                                <Button variant="outline-success"   variant="dark">   <FaUser /> Login</Button>
                                </Navbar.Collapse>
                         
                    </Navbar>
                    </Table>
                    {/* <p className="slide-container">
                        <Fade {...fadeProperties}>
                            <div className="each-fade">
                                <img src={fadeImages[0]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[1]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[2]} />
                            </div>
                        </Fade>
                    </p> */}
                    <Col className="pt-2 app-content-main">
                        <Switch>
                            <Route path="/home/ShowAllMuseums" component={ShowAllMuseums} />
                            <Route path="/home/ShowAllAuditoriums" component={ShowAllAuditoriums} />
                            <Route path="/home/ShowAllExhibitionsForUser" component={ShowAllExhibitionsForUser} />
                            <Route path="/home/ComingSoonExhibitionsForUser" component={ComingSoonExhibitionsForUser} />
                            <Route path="/home/CurrentExhibitionsForUser" component={CurrentExhibitionsForUser} />
                            <Route path="/home/ShowAllExhibits" component={ShowAllExhibits} />
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
             
            </Row>
        );
    }
}
export default Home;


 /* <Navbar bg="dark"  >
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

                </NavDropdown> */
               
