import React from 'react';
import Product from '../Product/Product';
import styles from './style.module.css';

export default function ProductList() {
    return (
        <section className={styles.roomsList}>
            <div className={styles.roomsListCenter}>
                {/* {rooms.map(item => {
                    return <Room key={item.id} room={item} />;
                })} */}
                <Product />
                <Product />
                <Product />
                <Product />
                <Product />
            </div>
        </section>
    );
}
