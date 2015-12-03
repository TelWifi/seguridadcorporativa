
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/03/2015 11:10:01
-- Generated from EDMX file: C:\Users\Erick Orlando\Documents\GitProjects\gromeroseguridad\Gromero.Seguridad.Datos\Gromero.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Seguridad];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__TARSEGCLA__IDUSR__571DF1D5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGCLAV] DROP CONSTRAINT [FK__TARSEGCLA__IDUSR__571DF1D5];
GO
IF OBJECT_ID(N'[dbo].[FK__TARSEGOPC__IDAPL__45F365D3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGOPCUI] DROP CONSTRAINT [FK__TARSEGOPC__IDAPL__45F365D3];
GO
IF OBJECT_ID(N'[dbo].[FK__TARSEGPER__IDAPL__2B3F6F97]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGPERFUS] DROP CONSTRAINT [FK__TARSEGPER__IDAPL__2B3F6F97];
GO
IF OBJECT_ID(N'[dbo].[FK__TARSEGPER__IDOPC__52593CB8]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGPERM] DROP CONSTRAINT [FK__TARSEGPER__IDOPC__52593CB8];
GO
IF OBJECT_ID(N'[dbo].[FK__TARSEGPER__IDROL__5070F446]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGPERM] DROP CONSTRAINT [FK__TARSEGPER__IDROL__5070F446];
GO
IF OBJECT_ID(N'[dbo].[FK__TARSEGPER__IDUSR__2A4B4B5E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGPERFUS] DROP CONSTRAINT [FK__TARSEGPER__IDUSR__2A4B4B5E];
GO
IF OBJECT_ID(N'[dbo].[FK__TARSEGPLP__IDOPC__4BAC3F29]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGPLPERM] DROP CONSTRAINT [FK__TARSEGPLP__IDOPC__4BAC3F29];
GO
IF OBJECT_ID(N'[dbo].[FK__TARSEGPLP__IDROL__4AB81AF0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGPLPERM] DROP CONSTRAINT [FK__TARSEGPLP__IDROL__4AB81AF0];
GO
IF OBJECT_ID(N'[dbo].[FK__TARSEGREC__IDREC__30F848ED]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGRECDET] DROP CONSTRAINT [FK__TARSEGREC__IDREC__30F848ED];
GO
IF OBJECT_ID(N'[dbo].[FK__TARSEGROL__IDAPL__3B75D760]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGROL] DROP CONSTRAINT [FK__TARSEGROL__IDAPL__3B75D760];
GO
IF OBJECT_ID(N'[dbo].[FK__TARSEGROL__IDPER__412EB0B6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGROLESPER] DROP CONSTRAINT [FK__TARSEGROL__IDPER__412EB0B6];
GO
IF OBJECT_ID(N'[dbo].[FK__TARSEGROL__IDROL__403A8C7D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGROLESPER] DROP CONSTRAINT [FK__TARSEGROL__IDROL__403A8C7D];
GO
IF OBJECT_ID(N'[dbo].[FK__TCMSEGUSE__IDCAR__25869641]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TCMSEGUSER] DROP CONSTRAINT [FK__TCMSEGUSE__IDCAR__25869641];
GO
IF OBJECT_ID(N'[dbo].[FK__TCMSEGUSE__IDEMP__24927208]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TCMSEGUSER] DROP CONSTRAINT [FK__TCMSEGUSE__IDEMP__24927208];
GO
IF OBJECT_ID(N'[dbo].[FK__TCRSEGCAS__IDCAR__1FCDBCEB]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TCRSEGCASOC] DROP CONSTRAINT [FK__TCRSEGCAS__IDCAR__1FCDBCEB];
GO
IF OBJECT_ID(N'[dbo].[FK__TCRSEGREC__IDAPL__0BC6C43E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TCRSEGRECAPL] DROP CONSTRAINT [FK__TCRSEGREC__IDAPL__0BC6C43E];
GO
IF OBJECT_ID(N'[dbo].[FK__TCRSEGREC__IDPER__35BCFE0A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TCRSEGRECPER] DROP CONSTRAINT [FK__TCRSEGREC__IDPER__35BCFE0A];
GO
IF OBJECT_ID(N'[dbo].[FK__TCRSEGREC__IDREC__0CBAE877]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TCRSEGRECAPL] DROP CONSTRAINT [FK__TCRSEGREC__IDREC__0CBAE877];
GO
IF OBJECT_ID(N'[dbo].[FK__TCRSEGREC__IDREC__36B12243]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TCRSEGRECPER] DROP CONSTRAINT [FK__TCRSEGREC__IDREC__36B12243];
GO
IF OBJECT_ID(N'[dbo].[FK_TARSEGPERM_TARSEGROLESPER]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARSEGPERM] DROP CONSTRAINT [FK_TARSEGPERM_TARSEGROLESPER];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TAMSEGREC]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TAMSEGREC];
GO
IF OBJECT_ID(N'[dbo].[TARSEGCLAV]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TARSEGCLAV];
GO
IF OBJECT_ID(N'[dbo].[TARSEGOPCUI]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TARSEGOPCUI];
GO
IF OBJECT_ID(N'[dbo].[TARSEGPERFUS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TARSEGPERFUS];
GO
IF OBJECT_ID(N'[dbo].[TARSEGPERM]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TARSEGPERM];
GO
IF OBJECT_ID(N'[dbo].[TARSEGPLPERM]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TARSEGPLPERM];
GO
IF OBJECT_ID(N'[dbo].[TARSEGRECDET]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TARSEGRECDET];
GO
IF OBJECT_ID(N'[dbo].[TARSEGROL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TARSEGROL];
GO
IF OBJECT_ID(N'[dbo].[TARSEGROLESPER]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TARSEGROLESPER];
GO
IF OBJECT_ID(N'[dbo].[TCMSEGAPLC]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TCMSEGAPLC];
GO
IF OBJECT_ID(N'[dbo].[TCMSEGCAR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TCMSEGCAR];
GO
IF OBJECT_ID(N'[dbo].[TCMSEGEMPR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TCMSEGEMPR];
GO
IF OBJECT_ID(N'[dbo].[TCMSEGUSER]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TCMSEGUSER];
GO
IF OBJECT_ID(N'[dbo].[TCRSEGCASOC]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TCRSEGCASOC];
GO
IF OBJECT_ID(N'[dbo].[TCRSEGRECAPL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TCRSEGRECAPL];
GO
IF OBJECT_ID(N'[dbo].[TCRSEGRECPER]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TCRSEGRECPER];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Claves'
CREATE TABLE [dbo].[Claves] (
    [IdClave] varchar(36)  NOT NULL,
    [IdUsuario] varchar(36)  NOT NULL,
    [Password] varchar(200)  NOT NULL,
    [Pregunta] varchar(200)  NOT NULL,
    [Respuesta] varchar(200)  NOT NULL,
    [Ultimo] bit  NOT NULL,
    [FechaCambio] datetime  NOT NULL
);
GO

-- Creating table 'RolesPerfiles'
CREATE TABLE [dbo].[RolesPerfiles] (
    [IdRolPerfil] varchar(36)  NOT NULL,
    [IdRol] varchar(36)  NOT NULL,
    [IdAplicacion] varchar(36)  NOT NULL,
    [IdPerfilUsuario] varchar(36)  NOT NULL
);
GO

-- Creating table 'Aplicaciones'
CREATE TABLE [dbo].[Aplicaciones] (
    [IdAplicacion] varchar(36)  NOT NULL,
    [NombreAplicacion] varchar(50)  NOT NULL,
    [Acronimo] varchar(20)  NOT NULL,
    [Uri] varchar(200)  NOT NULL,
    [Tipo] varchar(10)  NOT NULL
);
GO

-- Creating table 'Empresas'
CREATE TABLE [dbo].[Empresas] (
    [IdEmpresa] varchar(36)  NOT NULL,
    [CodigoEmpresa] varchar(20)  NOT NULL,
    [RazonSocial] varchar(150)  NOT NULL,
    [NombreCorto] nvarchar(50)  NOT NULL,
    [RUC] varchar(11)  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [IdUsuario] varchar(36)  NOT NULL,
    [IdEmpresa] varchar(36)  NOT NULL,
    [IdEmpresaPertenencia] varchar(36)  NOT NULL,
    [CodigoUsuario] varchar(200)  NOT NULL,
    [Nombres] varchar(200)  NULL,
    [ApellidoPaterno] varchar(20)  NOT NULL,
    [ApellidoMaterno] varchar(20)  NOT NULL,
    [DNI] varchar(20)  NOT NULL,
    [Estado] bit  NOT NULL,
    [Tipo] varchar(1)  NOT NULL,
    [Correo] varchar(200)  NOT NULL,
    [Dominio] varchar(50)  NOT NULL,
    [UltimoIngreso] datetime  NOT NULL,
    [IdCargoSociedad] varchar(36)  NOT NULL,
    [Alias] varchar(12)  NULL,
    [AliasAlterno] nvarchar(50)  NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [IdRol] varchar(36)  NOT NULL,
    [IdAplicacion] varchar(36)  NOT NULL,
    [CodigoRol] varchar(20)  NOT NULL,
    [NombreRol] varchar(100)  NOT NULL
);
GO

-- Creating table 'OpcionUI'
CREATE TABLE [dbo].[OpcionUI] (
    [IdOpcionUI] varchar(36)  NOT NULL,
    [IdAplicacion] varchar(36)  NOT NULL,
    [IdOpcionPadre] varchar(36)  NULL,
    [Codigo] varchar(50)  NOT NULL,
    [Nombre] varchar(250)  NOT NULL,
    [Tipo] varchar(20)  NOT NULL,
    [Clase] varchar(250)  NULL,
    [Url] varchar(250)  NULL,
    [Estado] bit  NOT NULL,
    [Nivel] int  NOT NULL,
    [NroOrden] int  NULL
);
GO

-- Creating table 'PerfilUsuario'
CREATE TABLE [dbo].[PerfilUsuario] (
    [IdPerfilUsuario] varchar(36)  NOT NULL,
    [IdUsuario] varchar(36)  NOT NULL,
    [IdAplicacion] varchar(36)  NOT NULL,
    [UltimoIngreso] datetime  NOT NULL,
    [Logueado] bit  NOT NULL,
    [Caduca] bit  NOT NULL,
    [VigenciaInicio] datetime  NOT NULL,
    [VigenciaFin] datetime  NOT NULL,
    [Usuario] varchar(20)  NOT NULL,
    [Placa] varchar(20)  NOT NULL
);
GO

-- Creating table 'Permiso'
CREATE TABLE [dbo].[Permiso] (
    [IdPermiso] varchar(36)  NOT NULL,
    [IdOpcionUI] varchar(36)  NOT NULL,
    [IdRol] varchar(36)  NOT NULL,
    [IdAplicacion] varchar(36)  NOT NULL,
    [IdUsuario] varchar(36)  NOT NULL,
    [Conceder] bit  NOT NULL,
    [IdRolPerfil] varchar(36)  NOT NULL,
    [Placa] varchar(20)  NOT NULL,
    [Usuario] varchar(20)  NOT NULL
);
GO

-- Creating table 'Plantilla'
CREATE TABLE [dbo].[Plantilla] (
    [IdPlantilla] varchar(36)  NOT NULL,
    [IdRol] varchar(36)  NOT NULL,
    [IdAplicacion] varchar(36)  NOT NULL,
    [IdOpcionUI] varchar(36)  NOT NULL,
    [Conceder] bit  NOT NULL
);
GO

-- Creating table 'Recurso'
CREATE TABLE [dbo].[Recurso] (
    [IdRecurso] varchar(36)  NOT NULL,
    [Descripcion] varchar(250)  NOT NULL,
    [RutaRecurso] varchar(250)  NOT NULL,
    [IdRecursoPadre] varchar(36)  NULL,
    [Nivel] int  NOT NULL
);
GO

-- Creating table 'RecursoDetalle'
CREATE TABLE [dbo].[RecursoDetalle] (
    [IdRecursoDetalle] varchar(36)  NOT NULL,
    [IdRecurso] varchar(36)  NOT NULL,
    [Codigo] varchar(20)  NOT NULL,
    [Descripcion] varchar(250)  NOT NULL,
    [IdRecursoDetallePadre] varchar(36)  NULL,
    [Nivel] int  NOT NULL
);
GO

-- Creating table 'RecursoAplicacion'
CREATE TABLE [dbo].[RecursoAplicacion] (
    [IdRecursoAplicacion] varchar(36)  NOT NULL,
    [IdAplicacion] varchar(36)  NOT NULL,
    [IdRecurso] varchar(36)  NOT NULL,
    [Conceder] bit  NOT NULL
);
GO

-- Creating table 'RecursoPerfil'
CREATE TABLE [dbo].[RecursoPerfil] (
    [IdRecursoPerfil] varchar(36)  NOT NULL,
    [IdPerfilUsuario] varchar(36)  NOT NULL,
    [IdRecursoDetalle] varchar(36)  NOT NULL,
    [Conceder] bit  NOT NULL
);
GO

-- Creating table 'Cargo'
CREATE TABLE [dbo].[Cargo] (
    [IdCargo] varchar(36)  NOT NULL,
    [CodigoCargo] varchar(20)  NOT NULL,
    [Descripcion] varchar(250)  NOT NULL,
    [Estado] bit  NOT NULL
);
GO

-- Creating table 'CargoSociedad'
CREATE TABLE [dbo].[CargoSociedad] (
    [IdCargoSociedad] varchar(36)  NOT NULL,
    [CodSociedadPropietaria] varchar(20)  NOT NULL,
    [IdCargo] varchar(36)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdClave] in table 'Claves'
ALTER TABLE [dbo].[Claves]
ADD CONSTRAINT [PK_Claves]
    PRIMARY KEY CLUSTERED ([IdClave] ASC);
GO

-- Creating primary key on [IdRolPerfil] in table 'RolesPerfiles'
ALTER TABLE [dbo].[RolesPerfiles]
ADD CONSTRAINT [PK_RolesPerfiles]
    PRIMARY KEY CLUSTERED ([IdRolPerfil] ASC);
GO

-- Creating primary key on [IdAplicacion] in table 'Aplicaciones'
ALTER TABLE [dbo].[Aplicaciones]
ADD CONSTRAINT [PK_Aplicaciones]
    PRIMARY KEY CLUSTERED ([IdAplicacion] ASC);
GO

-- Creating primary key on [IdEmpresa] in table 'Empresas'
ALTER TABLE [dbo].[Empresas]
ADD CONSTRAINT [PK_Empresas]
    PRIMARY KEY CLUSTERED ([IdEmpresa] ASC);
GO

-- Creating primary key on [IdUsuario] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC);
GO

-- Creating primary key on [IdRol] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([IdRol] ASC);
GO

-- Creating primary key on [IdOpcionUI] in table 'OpcionUI'
ALTER TABLE [dbo].[OpcionUI]
ADD CONSTRAINT [PK_OpcionUI]
    PRIMARY KEY CLUSTERED ([IdOpcionUI] ASC);
GO

-- Creating primary key on [IdPerfilUsuario] in table 'PerfilUsuario'
ALTER TABLE [dbo].[PerfilUsuario]
ADD CONSTRAINT [PK_PerfilUsuario]
    PRIMARY KEY CLUSTERED ([IdPerfilUsuario] ASC);
GO

-- Creating primary key on [IdPermiso] in table 'Permiso'
ALTER TABLE [dbo].[Permiso]
ADD CONSTRAINT [PK_Permiso]
    PRIMARY KEY CLUSTERED ([IdPermiso] ASC);
GO

-- Creating primary key on [IdPlantilla] in table 'Plantilla'
ALTER TABLE [dbo].[Plantilla]
ADD CONSTRAINT [PK_Plantilla]
    PRIMARY KEY CLUSTERED ([IdPlantilla] ASC);
GO

-- Creating primary key on [IdRecurso] in table 'Recurso'
ALTER TABLE [dbo].[Recurso]
ADD CONSTRAINT [PK_Recurso]
    PRIMARY KEY CLUSTERED ([IdRecurso] ASC);
GO

-- Creating primary key on [IdRecursoDetalle] in table 'RecursoDetalle'
ALTER TABLE [dbo].[RecursoDetalle]
ADD CONSTRAINT [PK_RecursoDetalle]
    PRIMARY KEY CLUSTERED ([IdRecursoDetalle] ASC);
GO

-- Creating primary key on [IdRecursoAplicacion] in table 'RecursoAplicacion'
ALTER TABLE [dbo].[RecursoAplicacion]
ADD CONSTRAINT [PK_RecursoAplicacion]
    PRIMARY KEY CLUSTERED ([IdRecursoAplicacion] ASC);
GO

-- Creating primary key on [IdRecursoPerfil] in table 'RecursoPerfil'
ALTER TABLE [dbo].[RecursoPerfil]
ADD CONSTRAINT [PK_RecursoPerfil]
    PRIMARY KEY CLUSTERED ([IdRecursoPerfil] ASC);
GO

-- Creating primary key on [IdCargo] in table 'Cargo'
ALTER TABLE [dbo].[Cargo]
ADD CONSTRAINT [PK_Cargo]
    PRIMARY KEY CLUSTERED ([IdCargo] ASC);
GO

-- Creating primary key on [IdCargoSociedad] in table 'CargoSociedad'
ALTER TABLE [dbo].[CargoSociedad]
ADD CONSTRAINT [PK_CargoSociedad]
    PRIMARY KEY CLUSTERED ([IdCargoSociedad] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdUsuario] in table 'Claves'
ALTER TABLE [dbo].[Claves]
ADD CONSTRAINT [FK__TARSEGCLA__IDUSR__4222D4EF]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TARSEGCLA__IDUSR__4222D4EF'
CREATE INDEX [IX_FK__TARSEGCLA__IDUSR__4222D4EF]
ON [dbo].[Claves]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdEmpresa] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [FK__TCMSEGUSE__IDEMP__21B6055D]
    FOREIGN KEY ([IdEmpresa])
    REFERENCES [dbo].[Empresas]
        ([IdEmpresa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TCMSEGUSE__IDEMP__21B6055D'
CREATE INDEX [IX_FK__TCMSEGUSE__IDEMP__21B6055D]
ON [dbo].[Usuarios]
    ([IdEmpresa]);
GO

-- Creating foreign key on [IdAplicacion] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [FK__TARSEGROL__IDAPL__0519C6AF]
    FOREIGN KEY ([IdAplicacion])
    REFERENCES [dbo].[Aplicaciones]
        ([IdAplicacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TARSEGROL__IDAPL__0519C6AF'
CREATE INDEX [IX_FK__TARSEGROL__IDAPL__0519C6AF]
ON [dbo].[Roles]
    ([IdAplicacion]);
GO

-- Creating foreign key on [IdRol] in table 'RolesPerfiles'
ALTER TABLE [dbo].[RolesPerfiles]
ADD CONSTRAINT [FK__TARSEGROL__IDROL__0EA330E9]
    FOREIGN KEY ([IdRol])
    REFERENCES [dbo].[Roles]
        ([IdRol])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TARSEGROL__IDROL__0EA330E9'
CREATE INDEX [IX_FK__TARSEGROL__IDROL__0EA330E9]
ON [dbo].[RolesPerfiles]
    ([IdRol]);
GO

-- Creating foreign key on [IdAplicacion] in table 'OpcionUI'
ALTER TABLE [dbo].[OpcionUI]
ADD CONSTRAINT [FK__TARSEGOPC__IDAPL__3B0BC30C]
    FOREIGN KEY ([IdAplicacion])
    REFERENCES [dbo].[Aplicaciones]
        ([IdAplicacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TARSEGOPC__IDAPL__3B0BC30C'
CREATE INDEX [IX_FK__TARSEGOPC__IDAPL__3B0BC30C]
ON [dbo].[OpcionUI]
    ([IdAplicacion]);
GO

-- Creating foreign key on [IdAplicacion] in table 'RolesPerfiles'
ALTER TABLE [dbo].[RolesPerfiles]
ADD CONSTRAINT [FK_TARSEGROLESPER_TCMSEGAPLC]
    FOREIGN KEY ([IdAplicacion])
    REFERENCES [dbo].[Aplicaciones]
        ([IdAplicacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TARSEGROLESPER_TCMSEGAPLC'
CREATE INDEX [IX_FK_TARSEGROLESPER_TCMSEGAPLC]
ON [dbo].[RolesPerfiles]
    ([IdAplicacion]);
GO

-- Creating foreign key on [IdOpcionUI] in table 'Permiso'
ALTER TABLE [dbo].[Permiso]
ADD CONSTRAINT [FK__TARSEGPER__IDOPC__09A971A2]
    FOREIGN KEY ([IdOpcionUI])
    REFERENCES [dbo].[OpcionUI]
        ([IdOpcionUI])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TARSEGPER__IDOPC__09A971A2'
CREATE INDEX [IX_FK__TARSEGPER__IDOPC__09A971A2]
ON [dbo].[Permiso]
    ([IdOpcionUI]);
GO

-- Creating foreign key on [IdOpcionUI] in table 'Plantilla'
ALTER TABLE [dbo].[Plantilla]
ADD CONSTRAINT [FK_TARSEGPLPERM_TARSEGOPCUI]
    FOREIGN KEY ([IdOpcionUI])
    REFERENCES [dbo].[OpcionUI]
        ([IdOpcionUI])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TARSEGPLPERM_TARSEGOPCUI'
CREATE INDEX [IX_FK_TARSEGPLPERM_TARSEGOPCUI]
ON [dbo].[Plantilla]
    ([IdOpcionUI]);
GO

-- Creating foreign key on [IdUsuario] in table 'PerfilUsuario'
ALTER TABLE [dbo].[PerfilUsuario]
ADD CONSTRAINT [FK__TARSEGPER__IDUSR__267ABA7A]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TARSEGPER__IDUSR__267ABA7A'
CREATE INDEX [IX_FK__TARSEGPER__IDUSR__267ABA7A]
ON [dbo].[PerfilUsuario]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdPerfilUsuario] in table 'RolesPerfiles'
ALTER TABLE [dbo].[RolesPerfiles]
ADD CONSTRAINT [FK__TARSEGROL__IDPER__0F975522]
    FOREIGN KEY ([IdPerfilUsuario])
    REFERENCES [dbo].[PerfilUsuario]
        ([IdPerfilUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TARSEGROL__IDPER__0F975522'
CREATE INDEX [IX_FK__TARSEGROL__IDPER__0F975522]
ON [dbo].[RolesPerfiles]
    ([IdPerfilUsuario]);
GO

-- Creating foreign key on [IdAplicacion] in table 'PerfilUsuario'
ALTER TABLE [dbo].[PerfilUsuario]
ADD CONSTRAINT [FK_TARSEGPERFUS_TCMSEGAPLC]
    FOREIGN KEY ([IdAplicacion])
    REFERENCES [dbo].[Aplicaciones]
        ([IdAplicacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TARSEGPERFUS_TCMSEGAPLC'
CREATE INDEX [IX_FK_TARSEGPERFUS_TCMSEGAPLC]
ON [dbo].[PerfilUsuario]
    ([IdAplicacion]);
GO

-- Creating foreign key on [IdRol] in table 'Permiso'
ALTER TABLE [dbo].[Permiso]
ADD CONSTRAINT [FK__TARSEGPER__IDROL__2D27B809]
    FOREIGN KEY ([IdRol])
    REFERENCES [dbo].[Roles]
        ([IdRol])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TARSEGPER__IDROL__2D27B809'
CREATE INDEX [IX_FK__TARSEGPER__IDROL__2D27B809]
ON [dbo].[Permiso]
    ([IdRol]);
GO

-- Creating foreign key on [IdAplicacion] in table 'Permiso'
ALTER TABLE [dbo].[Permiso]
ADD CONSTRAINT [FK_TARSEGPERM_TCMSEGAPLC]
    FOREIGN KEY ([IdAplicacion])
    REFERENCES [dbo].[Aplicaciones]
        ([IdAplicacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TARSEGPERM_TCMSEGAPLC'
CREATE INDEX [IX_FK_TARSEGPERM_TCMSEGAPLC]
ON [dbo].[Permiso]
    ([IdAplicacion]);
GO

-- Creating foreign key on [IdUsuario] in table 'Permiso'
ALTER TABLE [dbo].[Permiso]
ADD CONSTRAINT [FK_TARSEGPERM_TCMSEGUSER]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TARSEGPERM_TCMSEGUSER'
CREATE INDEX [IX_FK_TARSEGPERM_TCMSEGUSER]
ON [dbo].[Permiso]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdRol] in table 'Plantilla'
ALTER TABLE [dbo].[Plantilla]
ADD CONSTRAINT [FK__TARSEGPLP__IDROL__38996AB5]
    FOREIGN KEY ([IdRol])
    REFERENCES [dbo].[Roles]
        ([IdRol])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TARSEGPLP__IDROL__38996AB5'
CREATE INDEX [IX_FK__TARSEGPLP__IDROL__38996AB5]
ON [dbo].[Plantilla]
    ([IdRol]);
GO

-- Creating foreign key on [IdAplicacion] in table 'Plantilla'
ALTER TABLE [dbo].[Plantilla]
ADD CONSTRAINT [FK_TARSEGPLPERM_TCMSEGAPLC]
    FOREIGN KEY ([IdAplicacion])
    REFERENCES [dbo].[Aplicaciones]
        ([IdAplicacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TARSEGPLPERM_TCMSEGAPLC'
CREATE INDEX [IX_FK_TARSEGPLPERM_TCMSEGAPLC]
ON [dbo].[Plantilla]
    ([IdAplicacion]);
GO

-- Creating foreign key on [IdRecurso] in table 'RecursoDetalle'
ALTER TABLE [dbo].[RecursoDetalle]
ADD CONSTRAINT [FK__TARSEGREC__IDREC__4DE98D56]
    FOREIGN KEY ([IdRecurso])
    REFERENCES [dbo].[Recurso]
        ([IdRecurso])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TARSEGREC__IDREC__4DE98D56'
CREATE INDEX [IX_FK__TARSEGREC__IDREC__4DE98D56]
ON [dbo].[RecursoDetalle]
    ([IdRecurso]);
GO

-- Creating foreign key on [IdRecurso] in table 'RecursoAplicacion'
ALTER TABLE [dbo].[RecursoAplicacion]
ADD CONSTRAINT [FK__TCRSEGREC__IDREC__4924D839]
    FOREIGN KEY ([IdRecurso])
    REFERENCES [dbo].[Recurso]
        ([IdRecurso])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TCRSEGREC__IDREC__4924D839'
CREATE INDEX [IX_FK__TCRSEGREC__IDREC__4924D839]
ON [dbo].[RecursoAplicacion]
    ([IdRecurso]);
GO

-- Creating foreign key on [IdPerfilUsuario] in table 'RecursoPerfil'
ALTER TABLE [dbo].[RecursoPerfil]
ADD CONSTRAINT [FK__TCRSEGREC__IDPER__52AE4273]
    FOREIGN KEY ([IdPerfilUsuario])
    REFERENCES [dbo].[PerfilUsuario]
        ([IdPerfilUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TCRSEGREC__IDPER__52AE4273'
CREATE INDEX [IX_FK__TCRSEGREC__IDPER__52AE4273]
ON [dbo].[RecursoPerfil]
    ([IdPerfilUsuario]);
GO

-- Creating foreign key on [IdRecursoDetalle] in table 'RecursoPerfil'
ALTER TABLE [dbo].[RecursoPerfil]
ADD CONSTRAINT [FK__TCRSEGREC__IDREC__53A266AC]
    FOREIGN KEY ([IdRecursoDetalle])
    REFERENCES [dbo].[RecursoDetalle]
        ([IdRecursoDetalle])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TCRSEGREC__IDREC__53A266AC'
CREATE INDEX [IX_FK__TCRSEGREC__IDREC__53A266AC]
ON [dbo].[RecursoPerfil]
    ([IdRecursoDetalle]);
GO

-- Creating foreign key on [IdAplicacion] in table 'RecursoAplicacion'
ALTER TABLE [dbo].[RecursoAplicacion]
ADD CONSTRAINT [FK__TCRSEGREC__IDAPL__4830B400]
    FOREIGN KEY ([IdAplicacion])
    REFERENCES [dbo].[Aplicaciones]
        ([IdAplicacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TCRSEGREC__IDAPL__4830B400'
CREATE INDEX [IX_FK__TCRSEGREC__IDAPL__4830B400]
ON [dbo].[RecursoAplicacion]
    ([IdAplicacion]);
GO

-- Creating foreign key on [IdCargo] in table 'CargoSociedad'
ALTER TABLE [dbo].[CargoSociedad]
ADD CONSTRAINT [FK__TCRSEGCAS__IDCAR__308E3499]
    FOREIGN KEY ([IdCargo])
    REFERENCES [dbo].[Cargo]
        ([IdCargo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TCRSEGCAS__IDCAR__308E3499'
CREATE INDEX [IX_FK__TCRSEGCAS__IDCAR__308E3499]
ON [dbo].[CargoSociedad]
    ([IdCargo]);
GO

-- Creating foreign key on [IdCargoSociedad] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [FK_TCMSEGUSER_TCRSEGCASOC]
    FOREIGN KEY ([IdCargoSociedad])
    REFERENCES [dbo].[CargoSociedad]
        ([IdCargoSociedad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TCMSEGUSER_TCRSEGCASOC'
CREATE INDEX [IX_FK_TCMSEGUSER_TCRSEGCASOC]
ON [dbo].[Usuarios]
    ([IdCargoSociedad]);
GO

-- Creating foreign key on [IdRolPerfil] in table 'Permiso'
ALTER TABLE [dbo].[Permiso]
ADD CONSTRAINT [FK_TARSEGPERM_TARSEGROLESPER]
    FOREIGN KEY ([IdRolPerfil])
    REFERENCES [dbo].[RolesPerfiles]
        ([IdRolPerfil])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TARSEGPERM_TARSEGROLESPER'
CREATE INDEX [IX_FK_TARSEGPERM_TARSEGROLESPER]
ON [dbo].[Permiso]
    ([IdRolPerfil]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------