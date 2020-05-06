import React, { Component } from 'react';
import Search from './Search';
import { Switch, Route } from 'react-router-dom';
import { FaUser, FaSearch } from 'react-icons/fa';
import Popup from "reactjs-popup";
import { Fade } from 'react-slideshow-image';
import { Navbar, Table, Nav, Button, Container, Image, DropdownButton, DropdownItem, Carousel , Col, Row, FormControl, Form, InputGroup} from 'react-bootstrap';
import ShowAllExhibitionsForUser from './ExhibitionActions/ShowAllExhibitionsForUser';
import ExhibitionDetails from './ExhibitionActions/ExhibitionDetails';
import CurrentExhibitionsForUser from './ExhibitionActions/CurrentExhibitionsForUser'
import ComingSoonExhibitionsForUser from './ExhibitionActions/ComingSoonExhibitionsForUser'
import image1 from './Pictures/image4.jpg';
import image2 from './Pictures/image2.jpg';
import image3 from './Pictures/image3.jpg';
import image4 from './Pictures/image1.png';
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
const fadeImages = [image1, image2, image3, image4, image5, image6, image7, image8, image9, image10, image11, image12, image13, image14, image15, image16];

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
                                    <DropdownItem href="/home/ShowAllExhibitionsForUser">Sve izložbe</DropdownItem>
                                    <DropdownItem href="/home/ComingSoonExhibitionsForUser">Uskoro ćemo prikazivati</DropdownItem>
                                    <DropdownItem href="/home/CurrentExhibitionsForUser">Trenutno se prikazuju</DropdownItem>
                                </DropdownButton >
                            </Container>
                        </Nav>
                        <h4>|</h4>
                        <Nav className="mr-auto">
                            <Container>
                                <Navbar.Brand>
                                    <Button variant="outline-light" size="lg" active> <b>VESTI</b></Button>
                                </Navbar.Brand>
                            </Container>
                        </Nav>
                        <h4>|</h4>
                        <Nav className="mr-auto">
                            <Container>
                                <Navbar.Brand>
                                    <Button variant="outline-light" size="lg" active> O MUZEJU </Button>
                                </Navbar.Brand>
                            </Container>
                        </Nav>
                        <h4>|</h4>
                        <Nav className="mr-auto">
                            <Container>
                                <Navbar.Brand>
                                    <Button variant="outline-light" size="lg" active> KONTAKT </Button>
                                </Navbar.Brand>
                            </Container>
                        </Nav>
                        <Navbar.Collapse className="justify-content-end">
                            <Button variant="outline-light" size="lg" active onClick={this.openModal} className="login" >
                                <FaUser /> Login
                            </Button>
                            <Popup className="popup" open={this.state.open} closeOnDocumentClick onClose={this.closeModal}>
                                <a className="close" onClick={this.closeModal}>&times;</a>
                                <Form className="form">
                                    <Container>
                                        <Button variant="outline-light" size="lg" className="user" >
                                            <FaUser />
                                        </Button>
                                    </Container>
                                    <Container>
                                        <Form.Group controlId="formBasicEmail">
                                            <InputGroup className="mb-3">
                                                <InputGroup.Prepend>
                                                    <InputGroup.Text> Email address </InputGroup.Text>
                                                </InputGroup.Prepend>
                                                <FormControl />
                                            </InputGroup>
                                        </Form.Group>
                                    </Container>
                                    <Container>
                                        <Form.Group controlId="formBasicPassword">
                                            <InputGroup className="mb-3">
                                                <InputGroup.Prepend>
                                                    <InputGroup.Text> Email address </InputGroup.Text>
                                                </InputGroup.Prepend>
                                                <FormControl />
                                            </InputGroup>
                                        </Form.Group>
                                    </Container>
                                    <Container>
                                        <Form.Group controlId="formBasicCheckbox">
                                            <Form.Check type="checkbox" label="Check me out" />
                                        </Form.Group>
                                    </Container>
                                    <Container>
                                        <Button variant="primary" type="submit"> Submit </Button>
                                    </Container>
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
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[1]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[2]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[3]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[4]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[5]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[6]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[7]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[8]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[9]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[10]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[11]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[12]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[13]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[14]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
                            </Carousel.Caption>
                        </div>
                        <div className="each-fade">
                            <img src={fadeImages[15]} />
                            <Carousel.Caption className="welcomeMesssage">
                                <Search/> 
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