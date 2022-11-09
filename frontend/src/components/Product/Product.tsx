/* eslint-disable react/no-unescaped-entities */
import React from 'react';
import defaultImg from '../../images/laptop-1.png';
import styles from './style.module.css';

export default function Product() {
    return (
        <article className={styles.product}>
            <div className={styles.imgContainer}>
                <img src={defaultImg} alt="Single Product" />
                <div className={styles.priceTop}>
                    <h6>S/4,999.00</h6>
                </div>
                <button className={[styles.btnPrimary, styles.productLink].join(' ')}>
                    {''}
                    Características
                    {''}
                </button>
            </div>
            <p className={styles.productInfo}>
                Laptop Gamer Asus TUF Dash F15 FX517ZC 15.6' i5-12450H 512GB SSD 8G RTX3050 4GB
                White
            </p>
        </article>
    );
}
