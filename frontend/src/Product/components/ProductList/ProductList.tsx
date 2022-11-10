import React, { useEffect } from 'react';
import { useProduct } from '../../hooks/useProduct';
import { ProductItem } from '../ProductItem/ProductItem';
import styles from './style.module.css';

export const ProductList = () => {
	const { getAllProducts, products, price, orderBy, page } = useProduct();

	useEffect(() => {
		getAllProducts(orderBy, price, page).then((res) => console.log('response', res));
	}, [orderBy, price]);

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
