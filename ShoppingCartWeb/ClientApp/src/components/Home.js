import React, { Component } from 'react';
import HeaderBar from './UI/Headerbar/Headerbar';
import CategoryList from '../components/CategoryList/CategoryList';
import ProductList from './ProductList/ProductList';
import {Route,NavLink, Switch, Redirect} from 'react-router-dom';
 class Home extends Component {
  static displayName = Home.name;

  componentDidMount()
  {
    
  }
  
  render () {
    return (
       <div className='container'>
       
      
        {/* <HeaderBar></HeaderBar> */}
        <CategoryList></CategoryList> 
     
     
         </div>
    );


  }
}


export default Home;