import React, {Component } from 'react';
import axios from '../../axios-fetcher';
import Spinner from '../UI/Spinner/Spinner';

import Product from '../Product/Product';


import  './ProductList.css';

class ProductList extends Component{

    state={
        ProductList:[],
        loading: false,
        error: false,
        formattedProd:[],
        productExist:true
    }
    componentDidMount()
    {

        const query=new URLSearchParams(this.props.location.search);
        const ingredients ={};
        let id=0;
        for (let param of query.entries())
        {
            if(param[0]==='id')
            {
                id=param[1];
            }
        }

        this.setState( { loading: true } );
        axios.get("/products/GetProductsByCategory/"+id).then(response=>
            {
                console.log(response.data);
                this.setState({ProductList:response.data.result, loading:false})
                if(this.state.ProductList.length<=0)
                {
                    this.setState({productExist:false});
                }
                var Prod= this.state.ProductList.map(product=>
                { 
                    return(
                    <Product key={product.name} 
                        
                        name={product.name} 
                        productNumber={product.productNumber}
                        listprice={product.listPrice}
                        thumbnail={product.thumbNailPhoto}
                        clicked={() => this.clickForward(product.productCategoryId)} />
                    )
                });

             this.setState({formattedProd:Prod});
            }

        ).catch (err=>{
            console.log(err);
        });
        //console.log('FormattedProd:'+this.state.formattedProd);
    }

    clickForward=(id)=>{

    }

    
    render ()
    {
        let form=<Spinner> product list </Spinner>;
        if(this.state.loading==false)
        {
            form=
                <section className="Wrapper1"> 
                {this.state.formattedProd}
                </section>
        }
        if (this.state.productExist==false)
            {
            form=<div>No Products Found</div>
            }
        return (
            <div> 

                    {form}
                
            </div>
        )

    }
}


export default ProductList;
