import React from 'react';
import { useProduct } from '../../hooks/useProduct';
import styles from './style.module.css';

export const ProductFilter = () => {
	const { price, minPrice, maxPrice, orderBy } = useProduct();

	const orders = ['Mayor Precio', 'Menor Precio'].map((item, index) => {
		return (
			<option key={index} value={item}>
				{item}
			</option>
		);
	});
	return (
		<section className={styles.filterContainer}>
			<form className={styles.filterForm}>
				<div className={styles.formGroup}>
					<label htmlFor="orderBy"> Ordenar por:</label>
					<select
						name="orderBy"
						id="orderBy"
						value={orderBy}
						className={styles.formControl}
						// onChange={() => handleChange('DESC')}
					>
						{orders}
					</select>
				</div>
				<div className={styles.formGroup}>
					<label htmlFor="price">Precio del producto: S/ {price}</label>
					<input
						type="range"
						name="price"
						min={minPrice}
						max={maxPrice}
						id="price"
						value={price}
						className={styles.formControl}
						// onChange={handleChange}
					/>
				</div>
			</form>
		</section>
	);
};
