import React, {Component } from 'react';
import axios from '../../axios-fetcher';
import Post from '../Category/Category';
import {Link, Route} from 'react-router-dom';

import './CategoryList.css';

import ProductList from '../ProductList/ProductList';

class CategoryList extends Component {
    state = {
        posts: [],
        selectedPostId: null,
        error: false
    }

    componentDidMount () {
        axios.get( '/productcategories' )
            .then( response => {
                const posts = response.data;
                const updatedPosts = posts.map(post => {
                    return {
                        ...post
                       
                    }
                });
                this.setState({posts: updatedPosts});
                // console.log( response );
            } )
            .catch(error => {
                // console.log(error);
                this.setState({error: true});
            });

            //console.log(this.props.match.url);
    }

    postSelectedHandler = (id) => {
        
        this.props.history.push("/ProductList?id="+id);
    }
    render()
    {
        let posts = 
            (
            <div>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                 
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>
                <p style={{textAlign: 'center'}}>Something went wrong!</p>

                <p style={{textAlign: 'center'}}>Something went wrong!</p>
            </div>
            )
            ;
        if (!this.state.error) {
            posts = this.state.posts.map(post => {
                return (
                 
                        <Post key={post.productCategoryId} 
                        
                        title={post.name} 
                        author={post.author}
                        clicked={() => this.postSelectedHandler(post.productCategoryId)} />
                        
                
                )
            });
        }
        return (
            <div>
                <section className="Wrapper">
                 {posts}
                </section>
                {/* <Route path='/ProductList?id' exact component={ProductList}></Route> */}
            </div>
          
        )
    }
}


export default CategoryList;