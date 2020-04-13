import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import 'react-notifications/lib/notifications.css';
import 'react-bootstrap-typeahead/css/Typeahead.css';
import { Switch, Route } from 'react-router-dom';
import { NotificationContainer } from 'react-notifications';

// components
import Dashboard from './components/admin/Dashboard';
// higher order component

function App() {
  return (
    <React.Fragment>
      <div className="set-overflow-y">
      <Switch>
        <Route path="/dashboard" component={Dashboard} />
      </Switch>
      <NotificationContainer />
      </div>
    </React.Fragment>
  );
}

export default App;