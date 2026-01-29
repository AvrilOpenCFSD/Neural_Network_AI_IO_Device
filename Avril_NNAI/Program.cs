/*
*  Class Tree.
* -------------
* 
*			    Program
*					|
*                   |
*                   |
*   		Framework_NNAI
*					|
*					|
*					|
*			NeuralNetworks
*					|
*			   _____|__________________________________________________________________________________________________________________________________________________________________________________________________
*			   |                    |																 |																												  |
* 			Global				Algorithms															Data																											Execute
*									|																 |
*									|____________________________________________					 |_______________________________________________________________________________
*									|											|					 |									  |										    |		
*								SolutionLogic								NeuralPath				Input								Output									MachineAI (Data File)
*									|											|					 |									  |										    |				
*									L------------	Algorithms_Praise_0		 ___|__________			 L------------	Input_Praise_0		  L------------	Output_Praise_0			    |________________________
*									L------------	Algorithms_Praise_1		 |			  |			 L------------	Input_Praise_1		  L------------	Output_Praise_1			    |                       |
*									L------------	Algorithms_Praise_2		Linear		//ToDo		 L------------	Intput_Praise_1		  L------------	Output_Praise_1		       Node                 MetaData
*																																													|			
*																																													|_______________________________________________
*																																												    |					    |					|				
* 																																												NeuralPathSubSet	InputPraiseSubSet	OuputPraiseSubSet			
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avril_NNAI
{
    internal static class Program
    {
        static private Avril_NNAI.Framework_NNAI framework = null;

        [STAThread]
        static void Main()
        {
            Create_And_Run_UI();

            System.Console.WriteLine("started progrma entry.");
            framework = new Avril_NNAI.Framework_NNAI();
            while (framework == null) { /* wait untill is created */ }
            System.Console.WriteLine("created framework.");
            //framework.Initialise(framework);
            System.Console.WriteLine("framework initialised.");
        }
        static private void Create_And_Run_UI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static public Avril_NNAI.Framework_NNAI Get_Framework_NNAI()
        {
            return framework;
        }
    }
}