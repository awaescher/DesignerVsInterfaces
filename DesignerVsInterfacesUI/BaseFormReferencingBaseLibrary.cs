using BaseLibrary;

namespace DesignerVsInterfacesUI
{
	public partial class BaseFormReferencingBaseLibrary : Form, IBaseObject
	{
		public BaseFormReferencingBaseLibrary()
		{
			InitializeComponent();
		}

		public int DoBaseThings() => 1;
	}
}
