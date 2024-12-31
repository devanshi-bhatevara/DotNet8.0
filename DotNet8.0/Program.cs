using DotNet8._0;
using DotNet8._0.ComplexTypes;


////AliasAnyTypes
//AliasAnyTypes.AliasAnyTypesDemo();
//AliasAnyTypes.AliasAnyTypesDemo2((1,"Doctor from parammeter"));

////PrimaryConstructor
//PrimaryConstructor object1 = new PrimaryConstructor();
//PrimaryConstructor object2 = new PrimaryConstructor(1,"");
//PrimaryConstructor object3 = new PrimaryConstructor(1,"",3);

////CollectionExpressions
//CollectionExpressions.CollectionExpressionsDemo();

////DefaultLambdaParameters
//DefaultLambdaParameters.DefaultLambdaParametersDemo();

////ExperimentalAttributes
//ExperimentalAttributes.ExperimentalAttributeDemo(); //throws a compile time error
//ExperimentalAttributes.NonExperimentalAttributeDemo(); //doesn't throw any compile time error


////For DB creation and migration
//using var context = new AppDbContext();

//// Apply migrations and create the database
//context.Database.EnsureDeleted();
//context.Database.EnsureCreated();
