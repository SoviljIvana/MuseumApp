import React, { Component } from 'react';
import Search from './Search';
import { Switch, Route } from 'react-router-dom';
import { FaUser } from 'react-icons/fa';
import Popup from "reactjs-popup";
import { Fade } from 'react-slideshow-image';
import { Navbar, Table, Nav, Button, Container, Image, DropdownButton,ButtonGroup, Dropdown, DropdownItem, Carousel, Col, Row, FormControl, Form, InputGroup } from 'react-bootstrap';
import ShowAllExhibitionsForUser from './ExhibitionActions/ShowAllExhibitionsForUser';
import ExhibitionDetails from './ExhibitionActions/ExhibitionDetails';
import CurrentExhibitionsForUser from './ExhibitionActions/CurrentExhibitionsForUser'
import ComingSoonExhibitionsForUser from './ExhibitionActions/ComingSoonExhibitionsForUser'
import image1 from './Pictures/imagee.jpg';
import image2 from './Pictures/imagee1.jpg';
import image3 from './Pictures/imagee2.jpg';
import image4 from './Pictures/imagee3.jpg';
import image6 from './Pictures/imagee5.jpg';

import logo from './Pictures/logo1.png'
const fadeImages = [image1, image2, image3, image4, image6];

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
                    <Navbar sticky="top" className="slide-container" expand="lg" bg="light">
                        <Nav className="mr-auto">
                            <Container>
                                <Row>
                                    <Col xs={6} md={4}>
                                        <Image src={logo} roundedCircle />
                                    </Col>
                                </Row>
                            </Container>
                        </Nav>
                        <Nav className="mr-auto">
                            <Container>
                                <DropdownButton title="IZLOŽBE" className="btn-outline-light" variant="outline-light" size="lg" active>
                                    <DropdownItem href="/home/ShowAllExhibitionsForUser" ><button className="button1">Sve izložbe</button></DropdownItem>
                                    <DropdownItem href="/home/ComingSoonExhibitionsForUser" ><button className="button1">Uskoro </button></DropdownItem>
                                    <DropdownItem href="/home/CurrentExhibitionsForUser" ><button className="button1">Trenutno </button></DropdownItem>
                                </DropdownButton >
                            </Container>
                        </Nav>
                        <h4>|</h4>
                        <Nav className="mr-auto">
                            <Container>
                                <Button className="btn-outline-light" size="lg" active> <b>VESTI</b></Button>
                            </Container>
                        </Nav>
                        <h4>|</h4>
                        <Nav className="mr-auto">
                            <Container>
                                <Button className="btn-outline-light" size="lg" active> O MUZEJU </Button>
                            </Container>
                        </Nav>
                        <h4>|</h4>
                        <Nav className="mr-auto">
                            <Container>
                                <Button className="btn-outline-light" size="lg" > KONTAKT </Button>
                            </Container>
                        </Nav>
                        <Navbar.Collapse className="justify-content-end">
                            <Dropdown  as={ButtonGroup}>
                            <Dropdown.Toggle split  id="dropdown-custom-2"  >
                              
                              <Dropdown.Menu >
                                  <Dropdown.Item ><button className="button1">Kreirajte nalog</button></Dropdown.Item>
                              </Dropdown.Menu>
                              </Dropdown.Toggle>
                                    <Button variant="outline-light" size="lg" active onClick={this.openModal} className="login" >
                                        <FaUser /> Login
                        </Button>   
                            </Dropdown >
                            <Popup className="popup" open={this.state.open} closeOnDocumentClick onClose={this.closeModal}>
                                <a className="close" onClick={this.closeModal}>&times;</a>
                                <Form>
                                    <Form.Group controlId="formBasicEmail">
                                        <Form.Label>Email address</Form.Label>
                                        <Form.Control type="email" placeholder="Enter email" />
                                        <Form.Text className="text-muted">
                                            We'll never share your email with anyone else.
                                    </Form.Text>
                                    </Form.Group>
                                    <Form.Group controlId="formBasicPassword">
                                        <Form.Label>Password</Form.Label>
                                        <Form.Control type="password" placeholder="Password" />
                                    </Form.Group>
                                    <Form.Group controlId="formBasicCheckbox">
                                        <Form.Check type="checkbox" label="Check me out" />
                                    </Form.Group>
                                    <Button variant="primary" type="submit">Submit </Button>
                                </Form>
                            </Popup>
                        </Navbar.Collapse>
                    </Navbar>
                </Table>
                <p className="slide-container">
                    <Fade {...fadeProperties}>
                        <div className="each-fade">

                            <img src={fadeImages[0]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search />
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[1]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search />
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[2]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search />
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[3]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search />
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[4]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search />
                            </Carousel.Caption>
                        </div>
                    </Fade>
                </p>
                <Col className="pt-2 app-content-main">
                    <Switch>
                        <Route path="/home/ShowAllExhibitionsForUser" component={ShowAllExhibitionsForUser} />
                        <Route path="/home/ComingSoonExhibitionsForUser" component={ComingSoonExhibitionsForUser} />
                        <Route path="/home/CurrentExhibitionsForUser" component={CurrentExhibitionsForUser} />
                        <Route path="/home/ExhibitionDetails/:id" component={ExhibitionDetails} />
                    </Switch>
                </Col>
            </Row>
        );
    }
}
export default Home;