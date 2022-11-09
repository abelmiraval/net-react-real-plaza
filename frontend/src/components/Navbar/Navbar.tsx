import React, { Component } from 'react';
import logo from '../../images/logo.png';
import styles from './style.module.css';

export default class Navbar extends Component {
    render() {
        return (
            <nav className={styles.navbar}>
                <div className={styles.navCenter}>
                    <div className={styles.navHeader}>
                        <img src={logo} alt="Beach Resort" className={styles.logo} />
                        <button type="button" className={styles.navBtn}></button>
                    </div>
                </div>
            </nav>
        );
    }
}
