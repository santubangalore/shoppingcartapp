import React from 'react';
import classes from './Headerbar.css';

const HeaderBar=(props)=>
(
    <div className={classes.HeaderBar}>
        <input type='text' name='searchbox' placeholder="Enter search, e.g. kashmiri shawl"  size="70"></input>
        <button
        className={[classes.Button, classes[props.btnType]].join(' ')}
        onClick={props.clicked}>Search</button>
    </div>
)


export default HeaderBar;