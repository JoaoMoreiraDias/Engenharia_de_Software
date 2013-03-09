import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

/**
 * The test class codigoTest.
 *
 * @author  (your name)
 * @version (a version number or a date)
 */
public class codigoTest
{
    /**
     * Default constructor for test class codigoTest
     */
    public codigoTest()
    {
    }

    /**
     * Sets up the test fixture.
     *
     * Called before every test case method.
     */
    @Before
    public void setUp()
    {
    }

    /**
     * Tears down the test fixture.
     *
     * Called after every test case method.
     */
    @After
    public void tearDown()
    {
    }

    @Test
    public void teste1()
    {
        codigo codigo1 = new codigo("A1-B22");
        assertEquals(false, codigo1.verificar());

        codigo codigo2 = new codigo("a12-B2");
        assertEquals(false, codigo2.verificar());

        codigo codigo3 = new codigo("A000-B22");
        assertEquals(false, codigo3.verificar());

        codigo codigo4 = new codigo("A1-B-1");
        assertEquals(false, codigo4.verificar());

        codigo codigo5 = new codigo("*1-B2");
        assertEquals(false, codigo5.verificar());

        codigo codigo6 = new codigo("1A-B2");
        assertEquals(false, codigo6.verificar());
        
        codigo codigo7 = new codigo("A1-2B");
        assertEquals(false, codigo7.verificar());
        
        codigo codigo8 = new codigo("A12B");
        assertEquals(false, codigo8.verificar());
        
        codigo codigo9 = new codigo("*");
        assertEquals(false, codigo9.verificar());
        
        codigo codigo10 = new codigo("");
        assertEquals(false, codigo10.verificar());
        
        codigo codigo11 = new codigo("true");
        assertEquals(false, codigo11.verificar());
        
        codigo codigo12 = new codigo("A3-BB");
        assertEquals(false, codigo12.verificar());
    }
}

