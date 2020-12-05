package com.store.model;

import java.io.Serializable;
import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name = "purchase")
public class Purchase implements Serializable{

	/**
	 *
	 */
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name = "idPurchase")
	private Integer idPurchase;

	//@Column(name = "product")
	@OneToMany
	private List<Bill> bill;

	public Integer getIdPurchase() {
		return idPurchase;
	}

	public void setIdPurchase(Integer idPurchase) {
		this.idPurchase = idPurchase;
	}

	public static long getSerialversionuid() {
		return serialVersionUID;
	}

	public List<Bill> getBill() {
		return bill;
	}

	public void setBill(List<Bill> bill) {
		this.bill = bill;
	}
}
