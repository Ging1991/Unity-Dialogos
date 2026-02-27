using Ging1991.Core.Interfaces;
using Ging1991.Persistencia.Direcciones;
using Ging1991.Persistencia.Lectores;
using Ging1991.Persistencia.Lectores.Demandas;
using UnityEngine;

namespace Ging1991.Dialogos.Persistencia {

	public class LectorImagenes : LectorPorDemandaImagen, IProveedor<string, Sprite> {

		public LectorImagenes(Direccion direccionCarpeta) : base(direccionCarpeta, TipoLector.RECURSOS) { }

		public Sprite GetElemento(string nombre) {
			return Leer(nombre);
		}

	}

}