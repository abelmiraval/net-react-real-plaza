import React, { useEffect } from 'react';
import { useProduct } from '../../hooks/useProduct';
import { ProductItem } from '../ProductItem/ProductItem';
import styles from './style.module.css';

export const ProductList = () => {
	const { products, getAllProducts } = useProduct();

	useEffect(() => {
		getAllProducts().then((res) => console.log('response', res));
	}, []);

	return (
		<section className={styles.roomsList}>
			<div className={styles.roomsListCenter}>
				{products.map((item) => {
					return <ProductItem key={item.id} product={item} />;
				})}
			</div>
		</section>
	);
};
