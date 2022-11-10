import React, { useEffect } from 'react';
import { usePagination } from '../../hooks/usePagination';
import styles from './style.module.css';

export const ProductPagination = () => {
	const { getAllProducts, nextPage, prevPage, canNextPage, canPrevPage, price, orderBy, page } = usePagination();

	useEffect(() => {
		getAllProducts(orderBy, price, page).then((res) => console.log('response', res));
	}, [orderBy, price, page]);
	return (
		<div className={styles.pagination}>
			<button className={styles.pageLink} onClick={prevPage} disabled={!canPrevPage()}>
				<span>Anterior</span>
			</button>
			<button className={styles.pageLink} onClick={nextPage} disabled={!canNextPage()}>
				<span>Siguiente</span>
			</button>
		</div>
	);
};
