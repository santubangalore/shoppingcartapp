import React from 'react';

import classes from './Spinner.css';

const spinner = (props) => (
    <div className={classes.Loader}>Loading... {props.children}</div>
);

export default spinner;