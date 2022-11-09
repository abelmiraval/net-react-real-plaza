import React from 'react';
import styles from './style.module.css';

export default function RoomFilter() {
    return (
        <section className={styles.filterContainer}>
            <form className={styles.filterForm}>
                <div className={styles.formGroup}>
                    <label htmlFor="type"> Ordenar por:</label>
                    <select name="type" id="type" className={styles.formControl}>
                        <option value="Mayor Precio"> Todos</option>
                        <option value="Mayor Precio"> Mayor Precio</option>
                        <option value="Menor Precio"> Menor Precio</option>
                    </select>
                </div>
                <div className={styles.formGroup}>
                    <label htmlFor="price">Precio del producto: S/ 0</label>
                    <input
                        type="range"
                        name="price"
                        min="10"
                        max="200"
                        id="price"
                        className={styles.formControl}
                    />
                </div>
            </form>
        </section>
    );
}
