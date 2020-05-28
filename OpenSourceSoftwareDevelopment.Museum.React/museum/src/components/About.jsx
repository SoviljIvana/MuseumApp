import React from 'react';
import { withRouter } from 'react-router-dom';
import { Container, FormText} from 'react-bootstrap';

class About extends React.Component {
    render() {
        return (
            <Container>
                <h1>O muzeju </h1>
                <h6> Muzej Vojvodine je organizaciono razgranata ustanova, sa bogatim muzejskim fontomkoji broji oko 400.000 predmeta i bibliotečkim
                    fondom sa preko 50.000 publikacija. Redovna muzejska publikacija Rad Muzej Vojvodine, koja izlazi od 1952. godine,
                    nosila je naziv Rad vojvođanskih muzeja od 1995. godine. 
                    U uspostavljanju razgranate muzejske mreže stvoreni su depadansi- Etno park "Brvnara" u Bačkom Jarku i Muzejski kompleks Kulpin, 
                    koji se u sastavu Muzeja nalazi od 2004. godine.
                    <br></br>
                    Muzej Vojvodine pred javnost izlazi sa kompleksno izrađenom stalnom postavkom koja, u kontinuitetu od 8 hiljada godina, prezentuje
                    razvitak ljudskog društva na današnjem tlu Vojvodine.
                    <br></br>
                    Izloženi predmeti svedoče o trajanju ljudskih zajednica i kultura od paleolita i mezolita, od prvih ljudskih tragova kod Iriga 
                    starih 40.000 godina, preko starčevačke, vinčanske i drugih neolitskih kultura, do mitskih vremena stare Grčke i velelepnih spomenika 
                    imperijskog Rima, od seobe naroda do smena etničkih zajednica.
                    <br></br>
                    Muzej Vojvodine obavlja poslove matične delatnosti za sve ustanove zaštite pokretnih kulturnih dobara, 
                    muzeja i muzejskih zbirki na području Vojvodine, odnosno nadzor nad njihovim stručnim radom. </h6>
              <h6>
             </h6>
            </Container>
        );
    }
}
export default withRouter(About);