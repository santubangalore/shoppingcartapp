import React from 'react';

import './Product.css';




const product=(props)=>
{
   return(
            <article className="Product" onClick={props.clicked}>
                <h2>{props.name}</h2>
                <div >
                    <div >({props.productNumber}), ${props.listprice}</div>
                    <div > <img src={`data:image/jpeg;base64,${props.thumbnail}`} /></div>
                </div>
            </article>
    );
}

export default product;