import React, { Component } from 'react';
//import { Route } from 'react-router';
import {Route,BrowserRouter, Switch} from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import Login from './components/Login/Login';
import Checkout from './components/Containers/Checkout/Checkout';


import './custom.css'
import NavMenu from './components/NavMenu';

export default class App extends Component {
  static displayName = App.name;

  showSettings(event) {
      
    }
    
  render () {
    
    return (
      <BrowserRouter>
        <Switch>
        <Route exact path='/' component={Layout} />
        <Route path='/login' component={Login} >
            <NavMenu></NavMenu>
        </Route>
        <Route path='/checkout' component={Checkout} />
        </Switch>
      </BrowserRouter>
    );
  }
}
