CREATE TABLE [dbo].[PRODUCTO] (
    [PRODUCTO_PK]     UNIQUEIDENTIFIER NOT NULL,
    [Codigo_Producto] NVARCHAR (50)    NOT NULL,
    [Nombre]          NVARCHAR (50)    NOT NULL,
    [Descripcion]     NVARCHAR (300)   NOT NULL,
    [Cantidad]        INT              NOT NULL,
    [Precio]          DECIMAL (18, 2)  NOT NULL,
    [Estado]          BIT              NOT NULL,
    [Marca]           NVARCHAR (50)    NOT NULL,
    [Fecha_Ingreso]   DATE             NOT NULL,
    CONSTRAINT [PRODUCTO_PRODUCTO_PK_CK] PRIMARY KEY CLUSTERED ([PRODUCTO_PK] ASC),
    UNIQUE NONCLUSTERED ([Codigo_Producto] ASC)
);

