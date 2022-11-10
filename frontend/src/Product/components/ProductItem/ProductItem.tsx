/* eslint-disable react/no-unescaped-entities */
import React from 'react';
import { Product } from '../../interfaces/interfaces';
import styles from './style.module.css';

interface Props {
	product: Product;
}

export const ProductItem = ({ product }: Props) => {
	return (
		<article className={styles.product}>
			<div className={styles.imgContainer}>
				<img src={product.avatar} alt="Single Product" />
				<div className={styles.priceTop}>
					<h6>S/ {product.price}</h6>
				</div>
				<button className={[styles.btnPrimary, styles.productLink].join(' ')}>
					{''}
					Características
					{''}
				</button>
			</div>
			<p className={styles.productInfo}>{product.name}</p>
		</article>
	);
};
