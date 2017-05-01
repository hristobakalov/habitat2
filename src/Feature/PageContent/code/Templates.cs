namespace Sitecore.Feature.PageContent
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct HasPageContent
    {
      public static readonly ID ID = new ID("{AF74A00B-8CA7-4C9A-A5C1-156A68590EE2}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
        public const string Title_FieldName = "Title";
        public static readonly ID Summary = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
        public const string Summary_FieldName = "Summary";
        public static readonly ID Body = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
        public const string Body_FieldName = "Body";
        public static readonly ID Image = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
      }
    }
    public struct Content
        {
            public static readonly ID ID = new ID("{6F0FA044-731A-41C1-8831-5B3D35275A8E}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{0DBA28F0-75FF-4F2A-AB19-F4263AA52439}");
                public const string Title_FieldName = "Title";
                public static readonly ID Subtitle = new ID("{BED8FFDF-25D6-4402-A01B-722BFDFD6890}");
                public const string Subtitle_FieldName = "Subtitle";
                public static readonly ID Body = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string Body_FieldName = "Body";
                public static readonly ID Image = new ID("{2FF7595E-62A3-4694-B193-B5BE2AF145D2}");
            }
        }
  }
}