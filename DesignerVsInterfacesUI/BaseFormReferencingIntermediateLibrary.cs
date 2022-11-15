using IntermediateLibrary;

namespace DesignerVsInterfacesUI
{
	public partial class BaseFormReferencingIntermediateLibrary : Form, IIntermediateObject
	{
		public BaseFormReferencingIntermediateLibrary()
		{
			InitializeComponent();
		}

		public int DoIntermediateThings() => 1;
	}
}