import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import 'react-notifications/lib/notifications.css';
import 'react-bootstrap-typeahead/css/Typeahead.css';
import { Switch, Route, Redirect } from 'react-router-dom';
import { NotificationContainer } from 'react-notifications';
import Home from './components/Home'

function App() {
  return (
    <React.Fragment>
      <div className="set-overflow-y">
      <Switch>
        <Redirect exact from="/" to="home" />
        <Route path = "/home" component = {Home} />//for user
        {/* <Route path = "/dashboard" component = {Dashboard} /> //for admin */}
      </Switch>
      <NotificationContainer />
      </div>
    </React.Fragment>
  );
}

export default App;