import React, { Component } from 'react';
import { Col, Row } from 'react-bootstrap';
import { Switch, Route, Link } from 'react-router-dom';
import { FaUser, FaSearch } from 'react-icons/fa';
import { Navbar, Table, Nav,  Button, Container,Image } from 'react-bootstrap';
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
import Popup from "reactjs-popup";
 
import image1 from './Pictures/image1.png';
import image2 from './Pictures/image2.jpg';
import image3 from './Pictures/image3.jpg';
import image4 from './Pictures/image4.jpg';
import image5 from './Pictures/image5.jpg';
import image6 from './Pictures/image6.jpg';
import image7 from './Pictures/image7.jpg';
import image8 from './Pictures/image8.jpg';
import image9 from './Pictures/image9.jpg';
import image10 from './Pictures/image10.png';
import image11 from './Pictures/image11.jpg';
import image12 from './Pictures/image12.jpg';
import image13 from './Pictures/image13.jpg';
import image14 from './Pictures/image14.jpg';
import image15 from './Pictures/image15.jpg';
import image16 from './Pictures/image16.jpg';
import logo from './Pictures/logo.png'
import { Fade } from 'react-slideshow-image';
const fadeImages = [ image1,image2,image3, image4,image5,image6,image7, image8,image9, image10, image11,image12, image13,image14, image15,image16];

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
    constructor(props) {
        super(props);
        this.state = { open: false };
        this.openModal = this.openModal.bind(this);
        this.closeModal = this.closeModal.bind(this);
      }
      openModal() {
        this.setState({ open: true });
      }
      closeModal() {
        this.setState({ open: false });
      }
    render() {
        return (
              <Row className="no-gutters pr-0 pl-0" > 
                <Table>
                    <Navbar sticky="top" className="slide-container" expand="lg"  bg="light">
                    <Nav  className="mr-auto">
                        <Container>
                        <Row>
                        <Col xs={6} md={4}>
                            <Image src={logo} roundedCircle />
                        </Col>
                            </Row>
                        </Container>
                        </Nav>
                        <Nav  className="mr-auto">
                            <Container>
                                <Navbar.Brand ><Link to='/home/ShowAllExhibitionsForUser'><Button variant="light" >IZLOŽBE</Button></Link></Navbar.Brand>
                                </Container>
                        </Nav><h4>|</h4>
                        <Nav  className="mr-auto">
                            <Container>
                            <Navbar.Brand><Link to='/home/ComingSoonExhibitionsForUser'><Button variant="light">USKORO</Button></Link></Navbar.Brand>
                                </Container>
                        </Nav><h4>|</h4>
                        <Nav  className="mr-auto">
                            <Container>
                            <Navbar.Brand><Link to='/home/CurrentExhibitionsForUser'><Button variant="light" >PRIKAZUJEMO</Button></Link></Navbar.Brand>
                                </Container>
                        </Nav><h4>|</h4>
                        <Nav  className="mr-auto">
                            <Container>
                            <Navbar.Brand><Link to=''><Button variant="outline-light" size="lg"  active><b>VESTI</b></Button></Link></Navbar.Brand>
                                </Container>
                        </Nav><h4>|</h4>
                        <Nav  className="mr-auto">
                            <Container>
                            <Navbar.Brand><Link to=''><Button  variant="light">O MUZEJU</Button></Link></Navbar.Brand>
                                </Container>
                        </Nav><h4>|</h4>
                        <Nav  className="mr-auto">
                            <Container>
                            <Navbar.Brand><Link to=''><Button variant="light">KONTAKT</Button></Link></Navbar.Brand>                                   
                                </Container>
                        </Nav>
                                <Navbar.Collapse className="justify-content-end">
                               <Button variant="light" > <FaSearch /></Button> <h4>|</h4>
                                <Button variant="light"  onClick={this.openModal}>   <FaUser /> Login</Button>
                               
                                <Popup
          open={this.state.open}
          closeOnDocumentClick
          onClose={this.closeModal}>
          <div >
            <a className="close" onClick={this.closeModal}>
              &times;
            </a>
            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae magni
            omnis delectus nemo, maxime molestiae dolorem numquam mollitia, voluptate
            ea, accusamus excepturi deleniti ratione sapiente! Laudantium, aperiam
            doloribus. Odit, aut.
          </div>
        </Popup> </Navbar.Collapse>
                    </Navbar>
                    
                    </Table>
                    <p className="slide-container">
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
                            <div className="each-fade">
                                <img src={fadeImages[3]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[4]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[5]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[6]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[7]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[8]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[9]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[10]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[11]} />
                            </div><div className="each-fade">
                                <img src={fadeImages[12]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[13]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[14]} />
                            </div>
                            <div className="each-fade">
                                <img src={fadeImages[15]} />
                            </div>
                           
                       
                        </Fade>
                   
                    </p>
                  
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
               
