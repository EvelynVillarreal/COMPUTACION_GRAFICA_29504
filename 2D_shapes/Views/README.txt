Carpeta Views creada para alojar los formularios (Vistas).

Nota:
- Por compatibilidad con los archivos .Designer.cs y .resx, se recomienda mover los formularios (Frm*.cs, Frm*.Designer.cs y sus .resx) a esta carpeta usando Visual Studio (Solution Explorer -> Move) para que el .csproj se actualice correctamente.
- Si prefiere que yo mueva los archivos aquí y actualice el .csproj automáticamente, cierre la solución en Visual Studio (o indíquelo) y lo haré.

Actualmente los modelos están en Models\ y los controladores en Controllers\. Las vistas (formularios) permanecen en la raíz del proyecto para evitar problemas con el .csproj mientras la solución está abierta en Visual Studio.
