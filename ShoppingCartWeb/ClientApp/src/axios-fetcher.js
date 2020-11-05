import axios from 'axios';
import React, {Component } from "react";

const exiosfetcher = axios.create({
    baseURL: 'http://localhost:26413/api/'
});


export default  exiosfetcher;


