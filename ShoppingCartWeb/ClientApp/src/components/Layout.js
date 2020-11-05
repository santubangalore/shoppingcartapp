import React, { Component } from 'react';
import { Container } from 'reactstrap';
import NavMenu from './NavMenu';
import Sidebar from '../components/UI/SideBar/SideBar';
import '../Index.css';
import { slide as Menu } from 'react-burger-menu'
import Home from './Home';

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    const items = [
      { name: 'home', label: 'Home' },
      {
        name: 'billing',
        label: 'Billing',
      },
      {
        name: 'settings',
        label: 'Settings',
        items: [{ name: 'profile', label: 'Profile' }],
      },
    ]


    return (
      <div>
        <NavMenu />
        <Home></Home> 
        
      </div>
    );
  }
}
