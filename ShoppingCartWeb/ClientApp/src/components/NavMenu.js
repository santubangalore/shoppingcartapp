import React from 'react'
import './NavMenu.css';
import {Link} from 'react-router-dom';
import SearchIcon from '@material-ui/icons/Search';
import ShoppingBasketIcon from '@material-ui/icons/ShoppingBasket';

function NavMenu() {
    return (
        <nav className="header">
           <Link to="/">
            <img className="header_logo" src="http://pngimg.com/uploads/amazon/amazon_PNG11.png" alt=""/>
            {/* Logo img */}
          
           </Link>
          
            <div className="header_search">
                <input type="text" className="header__searchInput" />
                <SearchIcon className="header__searchIcon"/>
            </div>

            {/* 3 links    */}
            {/* Basket with number */}
            <div className="header__Nav">
                {/* 1st Link */}
                    <Link to="/Login" className="header__link">
                        <div className="header__option">
                            <span className="headerOption_lineOne">Hello Santu!!</span>
                            <span className="headerOption_lineTwo">Sign in</span>
                        </div>
                    </Link>
                    <Link to="/" className="header__link">
                        <div className="header__option">
                            <span className="headerOption_lineOne">Returns</span>
                            <span className="headerOption_lineTwo"> & Orders</span>
                        </div>
                    </Link>
                    <Link to="/" className="header__link">
                        <div className="header__option">
                            <span className="headerOption_lineOne">Your </span>
                            <span className="headerOption_lineTwo">Prime</span>
                        </div>
                    </Link>
            
                    <Link to="/checkout" className="header__link">
                        <div className="header_optionBasket">
                            <ShoppingBasketIcon></ShoppingBasketIcon>
                            <span className="headerOption_lineTwo header_basketCount">0</span>
                        </div> 
                    </Link>
            </div>

        </nav>
    )
}

export default NavMenu;
