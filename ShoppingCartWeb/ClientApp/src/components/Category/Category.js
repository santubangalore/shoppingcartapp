import React from 'react';
import {withRouter} from 'react-router-dom';

import './Category.css';

const category = (props) => {

    return(
            <article className="Category" onClick={props.clicked}>
                <h1>{props.title}</h1>
                <div className="Info">
                    <div className="Author">{props.author}</div>
                </div>
            </article>
    );
}

export default withRouter(category);