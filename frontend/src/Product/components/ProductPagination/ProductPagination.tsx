import React from 'react';
import { usePagination } from '../../hooks/usePagination';
import styles from './style.module.css';

export const ProductPagination = () => {
	const { nextPage, prevPage, canNextPage, canPrevPage } = usePagination();

	return (
		<div className={styles.pagination}>
			<button className={styles.pageLink} onClick={prevPage} disabled={canPrevPage()}>
				<span>Anterior</span>
			</button>
			<button className={styles.pageLink} onClick={nextPage} disabled={canNextPage()}>
				<span>Siguiente</span>
			</button>
		</div>
	);
};
