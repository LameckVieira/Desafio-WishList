import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Switch, Redirect } from 'react-router-dom';

import './index.css';

import App from './pages/home/App';
import tiposDesejos from './pages/tiposDesejos/tiposDesejos';
import NotFound from'./pages/notFound/notFound';

import reportWebVitals from './reportWebVitals';

const routing = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={App}/> {/*HomePage*/}
        <Route path="/tiposDesejos" component={tiposDesejos}/> {/*tiposDesejos page*/}
        <Route exact path="/notfound" component={NotFound} /> {/*Not Found page*/}
        <Redirect to="/notfound" /> {/*Redirects to NotFound if no route is found*/}
      </Switch>
    </div>
  </Router>
)

ReactDOM.render(routing, document.getElementById('root'));

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
